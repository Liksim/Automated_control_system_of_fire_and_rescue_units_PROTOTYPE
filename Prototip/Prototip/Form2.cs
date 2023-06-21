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

            bool canAddThisHotKey = false;

            foreach (string hotKeyStr in RescueEquipmentButton.HotKeys.Values)
            {
                if (ButtonHotKey.Text == hotKeyStr)
                {
                    canAddThisHotKey = true;
                }
            }

            if (!canAddThisHotKey && ButtonHotKey.Text != "")
            {
                AddErrorLabel.Text = "Нельзя использовать такую горячую клавишу!";
                AddErrorLabel.Visible = true;
                return;
            }

            RescueEquipmentButton entity = new RescueEquipmentButton(
                id: 0,
                name: ButtonName.Text,
                voicing: ButtonVoicing.Text,
                hotKey: ButtonHotKey.Text);

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
