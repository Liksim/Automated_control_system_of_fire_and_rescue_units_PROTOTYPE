using System.Drawing.Printing;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Media;
using Prototip.Buttons;

namespace Prototip
{
    public partial class Form1 : Form
    {
        private readonly Print print = new();
        private readonly TextToSpeech textToSpeech = new();

        public Form1()
        {
            InitializeComponent();
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

        public void textToSpeechButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["address"] = address.Text,
                ["typeOfIncident"] = typeOfIncident.Text,
            };

            textToSpeech.textToSpeech(data);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        private void button22345_Click(object sender, EventArgs e)
        {
            Button test = new Button();
            Controls.Add(test);
            tableLayoutPanel8.Controls.Add(test, 2, 0);
        }
    }
}