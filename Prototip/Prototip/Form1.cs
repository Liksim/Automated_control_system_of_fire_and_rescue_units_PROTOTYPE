using System.Drawing.Printing;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;
using Prototip.Buttons;
using System.Windows.Forms;

namespace Prototip
{
    public partial class Form1 : Form
    {
        private readonly Print print = new();
        private readonly TextToSpeech textToSpeech = new();

        public Form1()
        {
            InitializeComponent();
            AddRescueEquipmentButtons();
        }

        private void printByPrinterButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["address"] = address.Text,
                ["typeOfIncident"] = typeOfIncident.Text,
                ["fio"] = fio.Text,
                ["number"] = number.Text,
                ["timeHours"] = timeHours.Text,
                ["timeMinutes"] = timeMinutes.Text,
                ["dateOfReceipt"] = dateOfReceipt.Text
            };

            print.print(data);
        }

        public void TextToSpeechButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["address"] = address.Text,
                ["typeOfIncident"] = typeOfIncident.Text,
                ["buttonVoicing"] = ((Button)sender).Tag.ToString()
            };

            textToSpeech.textToSpeech(data);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        public void AddRescueEquipmentButtons()
        {
            BDconnection con = new BDconnection();
            List<RescueEquipmentButton> buttonsData = con.SelectButtons();

            tableLayoutPanel14.RowStyles[0] = new RowStyle(SizeType.Absolute, 46F);

            foreach (RescueEquipmentButton buttonData in buttonsData)
            {
                Button button = new Button();
                button.Anchor = AnchorStyles.Bottom;
                button.Location = new Point(51, 6);
                button.Margin = new Padding(3, 4, 3, 4);
                button.MinimumSize = new Size(126, 36);
                button.Name = buttonData.Name;
                button.Size = new Size(126, 36);
                button.TabIndex = 32;
                button.Text = buttonData.Name;
                button.Tag = buttonData.Voicing;
                button.UseVisualStyleBackColor = true;
                button.Click += TextToSpeechButton_Click;

                if (buttonsData.IndexOf(buttonData) != 0)
                {
                    tableLayoutPanel13.ColumnCount += 1;
                }

                tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                tableLayoutPanel13.Controls.Add(button, 0, 0);
            }
        }
    }
}