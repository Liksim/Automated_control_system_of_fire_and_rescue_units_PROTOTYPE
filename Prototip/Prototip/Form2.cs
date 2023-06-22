using Prototip.Buttons;

namespace Prototip
{
    public partial class Form2 : Form
    {
        Form1 form1;
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

            if(hotKeyButton.Text.Length < 4)
            {
                hotKeyStr = hotKeyButton.Text;
            }
            

            RescueEquipmentButton entity = new RescueEquipmentButton(
                id: 0,
                name: ButtonName.Text,
                voicing: ButtonVoicing.Text,
                hotKey: hotKeyStr);

            BDconnection con = new BDconnection();
            con.AddButton(entity);
            reloadData();
        }

        private void reloadData()
        {
            BDconnection con = new BDconnection();
            List<RescueEquipmentButton> buttons = con.SelectButtons();

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

            BDconnection con = new BDconnection();
            con.DeleteButton(Int32.Parse(ButtonId.Text));
            reloadData();
        }
    }
}
