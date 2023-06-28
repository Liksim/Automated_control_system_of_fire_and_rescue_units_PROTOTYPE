using Prototip.Buttons;
using Prototip.DBconnection;
using Prototip.DBconnection.Entities;
using System.Diagnostics;
using VkBotFramework;

namespace Prototip
{
    public partial class Form1 : Form
    {
        private readonly Print print = new();
        private readonly TextToSpeech textToSpeech = new();
        Repository<RescueEquipmentButton> buttonRepository = new Repository<RescueEquipmentButton>(ContextManager.GetContext());
        Repository<PPD> PPDRepository = new Repository<PPD>(ContextManager.GetContext());
        Repository<PPDType> PPDTypeRepository = new Repository<PPDType>(ContextManager.GetContext());

        public Form1()
        {
            InitializeComponent();
            AddRescueEquipmentButtons();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(KeyHandler);

            _bot = new VkBot(AccessToken, GroupUrl);
        }

        private void printByPrinterButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["address"] = address.Text,
                ["typeOfIncident"] = typeOfIncident.Text,
                ["fio"] = fio.Text,
                ["number"] = number.Text,
                ["dateOfReceipt"] = dateOfReceipt.Text
            };

            print.print(data);
        }

        private List<Button> RescueEquipmentButtons;

        void KeyHandler(object sender, KeyEventArgs e)
        {
            var buttonsData = buttonRepository.Read().ToList();

            foreach (RescueEquipmentButton buttonData in buttonsData)
            {
                string hotKeyStr = null;
                RescueEquipmentButton.HotKeys.TryGetValue((Keys)e.KeyValue, out hotKeyStr);

                if (buttonData.HotKey == hotKeyStr)
                {
                    Select_Click(RescueEquipmentButtons[buttonsData.IndexOf(buttonData)], e);
                }
            }

        }

        public void Select_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.OrangeRed)
            {
                ((Button)sender).BackColor = Color.White;
            }
            else if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.OrangeRed;
            }
        }

        public void TextToSpeechButton_Click(object sender, EventArgs e)
        {
            string buttonVoicing = "";

            foreach (Button button in RescueEquipmentButtons)
            {
                if (button.BackColor == Color.OrangeRed)
                {
                    buttonVoicing += button.Tag.ToString();
                    buttonVoicing += ", ";
                }
            }


            Dictionary<string, string> data = new Dictionary<string, string>
            {
                ["address"] = address.Text,
                ["typeOfIncident"] = typeOfIncident.Text,
                ["buttonVoicing"] = buttonVoicing
            };

            textToSpeech.textToSpeech(data);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
        }

        public void AddRescueEquipmentButtons()
        {
            var buttonsData = buttonRepository.Read().ToList();

            tableLayoutPanel13.Controls.Clear();
            tableLayoutPanel13.ColumnCount = buttonsData.Count;

            tableLayoutPanel14.RowStyles[0] = new RowStyle(SizeType.Absolute, 46F);

            List<Button> RescueEquipmentButtons = new() { };

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
                button.BackColor = Color.White;
                button.UseVisualStyleBackColor = true;
                button.Click += Select_Click;

                tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tableLayoutPanel13.Controls.Add(button, buttonsData.IndexOf(buttonData), 0);

                RescueEquipmentButtons.Add(button);
            }

            this.RescueEquipmentButtons = RescueEquipmentButtons;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            address.Clear();
            typeOfIncident.Clear();
            fio.Clear();
            number.Clear();
            dateOfReceipt.ResetText();
            foreach (Button button in RescueEquipmentButtons)
            {
                button.BackColor = Color.White;
            }
        }

        private void addressTextBox_Focus(object sender, EventArgs e)
        {
            var patternsArr = address.Text.Split(new char[] { ' ' });

            var patternsRawList = patternsArr.ToList();

            var patternsList = new List<string>();

            foreach (string s in patternsRawList)
            {
                if (!s.Contains('.'))
                {
                    patternsList.Add(s);
                }
            }

            string commandText =
                "select id as Id, organization_name as OrganizationName, address, number_in_departament as NumberInDepartament, id_ppd_type as IdPPDType " +
                "from ppd " +
                "where ";

            foreach (string pattern in patternsList)
            {
                commandText += $" address like \"%{pattern}%\"";

                if (patternsList.IndexOf(pattern) != patternsList.Count - 1)
                {
                    commandText += " and";
                }
                else
                {
                    commandText += ";";
                }
            }

            var PPDs = PPDRepository.SQL<PPD>(commandText).ToList();

            PPDsData.Rows.Clear();

            for (int i = 0; i < PPDs.Count; i++)
            {
                PPDsData.Rows.Add();
                PPDsData.Rows[i].Cells[0].Value = PPDs[i].NumberInDepartament;
                PPDsData.Rows[i].Cells[1].Value = PPDs[i].OrganizationName;
                PPDsData.Rows[i].Cells[2].Value = PPDs[i].Address;
                PPDsData.Rows[i].Cells[3].Value = PPDTypeRepository.Read(PPDs[i].IdPPDType).Name;
            }
        }

        private static string AccessToken = "vk1.a.ZkjDmAxVfiNzN_XR_DZGuqiULsLGFHpH6yLlVorHcky4fD1EbAW20LLuHt2gpaZRMJuIHIu5zpkiLK8HbwaQYQ_Dqw76mv0m0beRgFDhsD2V-YPZI-ShNKMPoVNLgGumLW_qjo-UV441othCZzbyJJErsyGz7_JH-FE9i_E33QUzIadSPlSo6_Tv0VqM2vG48qotMNaZ-OeOy8cH7RZBJQ";
        private static string GroupUrl = "https://vk.com/club221296482";
        private static VkBot _bot;

        private void mailingButton_Click(object sender, EventArgs e)
        {
            string message = "";

            foreach (Button button in RescueEquipmentButtons)
            {
                if (button.BackColor == Color.OrangeRed)
                {
                    //message += button.Tag.ToString();
                    message += button.Text;

                    message += ", ";
                }
            }

            if (message.Length > 0)
            {
                message = message.Substring(0, message.Length - 2);
            }

            string[] dateTimeValues = dateOfReceipt.Text.Split();
            dateTimeValues[4] = dateTimeValues[4].Insert(4, " ");
            dateTimeValues[4] = dateTimeValues[4].Insert(dateTimeValues[4].Length - 4, " ");

            message +=
                "\r\n" + address.Text +
                "\r\n" + typeOfIncident.Text +
                "\r\nСообщал: " + fio.Text + " " + number.Text +
                "\r\nДоп. информация: \r\n" + details.Text +
                "\r\n" + dateTimeValues[0] + " " + dateTimeValues[4];


            _bot.Api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams()
            {
                Message = message,
                PeerId = 2000000010,
                RandomId = Environment.TickCount
            });
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            string addressStr = address.Text.Replace(" ", "");

            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start https://yandex.ru/maps/38/volgograd/search/{addressStr}",
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }
    }
}