using Prototip.Buttons;
using Prototip.DBconnection;
using Prototip.DBconnection.Entities;
using System.Globalization;

namespace Prototip
{
    public partial class Form2 : Form
    {
        Form1 form1;
        Repository<RescueEquipmentButton> buttonRepository = new Repository<RescueEquipmentButton>(ContextManager.GetContext());
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
            reloadData();
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
                HotKey = hotKeyStr
            };

            buttonRepository.Create(rescueEquipmentButton);
            reloadData();
        }

        private void reloadData()
        {
            var buttons = buttonRepository.Read().ToList();

            ButtonsData.Rows.Clear();

            for (int i = 0; i < buttons.Count; i++)
            {
                ButtonsData.Rows.Add();
                ButtonsData.Rows[i].Cells[0].Value = buttons[i].Id;
                ButtonsData.Rows[i].Cells[1].Value = buttons[i].Name;
                ButtonsData.Rows[i].Cells[2].Value = buttons[i].Voicing;
                ButtonsData.Rows[i].Cells[3].Value = buttons[i].HotKey;
            }

            form1.AddRescueEquipmentButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            AddErrorLabel.Visible = false;
            DeleteErrorLabel.Visible = false;

            if (ButtonId.Text == "")
            {
                DeleteErrorLabel.Text = "Введите ID!";
                DeleteErrorLabel.Visible = true;
                return;
            }

            buttonRepository.Delete(Int32.Parse(ButtonId.Text));
            reloadData();
        }

        private void alertLocationButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            alertLocation.Text = openFileDialog1.FileName;
        }
    }
}
