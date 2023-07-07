using DocumentFormat.OpenXml.Bibliography;
using Prototip.Buttons;
using Prototip.DBconnection;
using Prototip.DBconnection.Entities;
using System.Globalization;

namespace Prototip
{
    public partial class Form2 : Form
    {
        Form1 form1;
        Repository<RescueEquipmentButton> rescueEquipmentButtonRepository = new Repository<RescueEquipmentButton>(ContextManager.GetContext());
        Repository<GlobalSettings> globalSettingsRepository = new Repository<GlobalSettings>(ContextManager.GetContext());


        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            reloadRescueEquipmentButtons();
            reloadGlobalSettings();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(KeyHandler);
        }

        void KeyHandler(object sender, KeyEventArgs e)
        {
            if (hotKeyButton.Text == "Нажмите F1-F12")
            {
                foreach (Keys key in RescueEquipmentButton.HotKeys.Keys)
                {
                    if (key == (Keys)e.KeyValue)
                    {
                        hotKeyButton.Text = RescueEquipmentButton.HotKeys[key];
                        return;
                    }
                }

                hotKeyButton.Text = "Выбрать";
            }
        }

        private void hotKeyButton_Click(object sender, EventArgs e)
        {
            if (hotKeyButton.Text == "Выбрать")
            {
                hotKeyButton.Text = "Нажмите F1-F12";
            }
            else
            {
                hotKeyButton.Text = "Выбрать";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddErrorLabel.Visible = false;
            DeleteErrorLabel.Visible = false;

            foreach (DataGridViewRow row in ButtonsData.Rows)
            {
                if (row.Cells[1].Value.Equals(ButtonName.Text))
                {
                    AddErrorLabel.Text = "Надпись на кнопке не уникальна!";
                    AddErrorLabel.Visible = true;
                    return;
                }
            }

            if (ButtonName.Text == "" || ButtonVoicing.Text == "")
            {
                AddErrorLabel.Text = "Надпись и текст кнопки должны быть заполнены!";
                AddErrorLabel.Visible = true;
                return;
            }

            string hotKeyStr = "";

            if (hotKeyButton.Text.Length < 4)
            {
                hotKeyStr = hotKeyButton.Text;
            }

            RescueEquipmentButton rescueEquipmentButton = new RescueEquipmentButton
            {
                Name = ButtonName.Text,
                Voicing = ButtonVoicing.Text,
                HotKey = hotKeyStr,
                IdDepartment = form1.IdDepartment
            };

            rescueEquipmentButtonRepository.Create(rescueEquipmentButton);
            reloadRescueEquipmentButtons();
        }

        private void reloadRescueEquipmentButtons()
        {
            var buttons = rescueEquipmentButtonRepository.Read().Where(x => x.IdDepartment == form1.IdDepartment).ToList();

            ButtonsData.Rows.Clear();

            for (int i = 0; i < buttons.Count; i++)
            {
                ButtonsData.Rows.Add();
                ButtonsData.Rows[i].Cells[0].Value = i + 1;
                ButtonsData.Rows[i].Cells[1].Value = buttons[i].Name;
                ButtonsData.Rows[i].Cells[2].Value = buttons[i].Voicing;
                ButtonsData.Rows[i].Cells[3].Value = buttons[i].HotKey;
                ButtonsData.Rows[i].Tag = buttons[i].Id;
            }

            form1.AddRescueEquipmentButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AddErrorLabel.Visible = false;
            DeleteErrorLabel.Visible = false;

            var selectedCells = ButtonsData.SelectedCells;
            List<int> IDsForDelete = new List<int>();

            for (int i = 0; i < selectedCells.Count; i++)
            {
                IDsForDelete.Add((int)selectedCells[i].OwningRow.Tag);
            }

            IDsForDelete = IDsForDelete.Distinct().ToList();

            foreach (int ID in IDsForDelete)
            {
                rescueEquipmentButtonRepository.Delete(ID);
            }

            reloadRescueEquipmentButtons();
        }

        private void alertLocationButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            alertLocation.Text = openFileDialog1.FileName;
        }

        private void saveGlobalSettingsButton_Click(object sender, EventArgs e)
        {
            var entity = globalSettingsRepository.Read(form1.IdDepartment);
            if (entity != null)
            {
                entity.Name = departmentName.Text;
                entity.AlertLocation = alertLocation.Text;
                globalSettingsRepository.Update(entity);
            }
            else
            {
                globalSettingsRepository.Create(new GlobalSettings(
                    id: form1.IdDepartment,
                    name: departmentName.Text,
                    alertLocation: alertLocation.Text
                    ));
            }
            reloadGlobalSettings();
        }

        private void reloadGlobalSettings()
        {
            var entityList = globalSettingsRepository.Read().Where(x => x.Id == form1.IdDepartment);

            if (entityList.Count() > 0)
            {
                GlobalSettings entity = entityList.First();
                departmentName.Text = entity.Name;
                alertLocation.Text = entity.AlertLocation;
            }
        }
    }
}
