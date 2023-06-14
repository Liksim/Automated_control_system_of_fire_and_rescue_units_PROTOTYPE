namespace Prototip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            address = new TextBox();
            label2 = new Label();
            typeOfIncident = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            fio = new TextBox();
            number = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            label1 = new Label();
            timeMinutes = new TextBox();
            timeHours = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label6 = new Label();
            dateOfReceipt = new DateTimePicker();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            printByPrinterButton = new Button();
            textToSpeechButton = new Button();
            button22345 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStrip1 = new MenuStrip();
            Settings = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // address
            // 
            address.Dock = DockStyle.Fill;
            address.Location = new Point(3, 52);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(397, 27);
            address.TabIndex = 3;
            address.Text = "сп. Поселение ул. Уличная д. 1111";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 2;
            label2.Text = "Место пожара (ЧС), адрес:";
            // 
            // typeOfIncident
            // 
            typeOfIncident.Dock = DockStyle.Fill;
            typeOfIncident.Location = new Point(3, 52);
            typeOfIncident.Margin = new Padding(3, 4, 3, 4);
            typeOfIncident.Name = "typeOfIncident";
            typeOfIncident.Size = new Size(397, 27);
            typeOfIncident.TabIndex = 5;
            typeOfIncident.Text = "Горит частный дом";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 4;
            label3.Text = "Объект пожара (характер ЧС):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 39);
            label4.Name = "label4";
            label4.Size = new Size(220, 20);
            label4.TabIndex = 6;
            label4.Text = "Время получения сообщения:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 14);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 12;
            label7.Text = "ФИО заявителя:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 13;
            label8.Text = "Номер телефона:";
            // 
            // fio
            // 
            fio.Dock = DockStyle.Fill;
            fio.Location = new Point(3, 52);
            fio.Margin = new Padding(3, 4, 3, 4);
            fio.Name = "fio";
            fio.Size = new Size(397, 27);
            fio.TabIndex = 14;
            fio.Text = "Иванов Иван Иванович";
            // 
            // number
            // 
            number.Dock = DockStyle.Fill;
            number.Location = new Point(3, 52);
            number.Margin = new Padding(3, 4, 3, 4);
            number.Name = "number";
            number.Size = new Size(397, 27);
            number.TabIndex = 15;
            number.Text = "8 800 555 35 35";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(address, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(403, 96);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(typeOfIncident, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(412, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(403, 96);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label7, 0, 0);
            tableLayoutPanel4.Controls.Add(fio, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 4);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(403, 96);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(number, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(412, 4);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(403, 96);
            tableLayoutPanel5.TabIndex = 24;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 5;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(label1, 2, 0);
            tableLayoutPanel9.Controls.Add(timeMinutes, 3, 0);
            tableLayoutPanel9.Controls.Add(label4, 0, 0);
            tableLayoutPanel9.Controls.Add(timeHours, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 4);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(403, 98);
            tableLayoutPanel9.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(263, 39);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 34;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeMinutes
            // 
            timeMinutes.Anchor = AnchorStyles.None;
            timeMinutes.Location = new Point(281, 35);
            timeMinutes.Name = "timeMinutes";
            timeMinutes.Size = new Size(24, 27);
            timeMinutes.TabIndex = 32;
            timeMinutes.Text = "38";
            // 
            // timeHours
            // 
            timeHours.Anchor = AnchorStyles.None;
            timeHours.Location = new Point(233, 35);
            timeHours.Name = "timeHours";
            timeHours.Size = new Size(24, 27);
            timeHours.TabIndex = 32;
            timeHours.Text = "16";
            timeHours.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label6, 0, 0);
            tableLayoutPanel10.Controls.Add(dateOfReceipt, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(412, 4);
            tableLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(403, 98);
            tableLayoutPanel10.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 39);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 28;
            label6.Text = "Дата:";
            // 
            // dateOfReceipt
            // 
            dateOfReceipt.Anchor = AnchorStyles.Left;
            dateOfReceipt.Location = new Point(58, 35);
            dateOfReceipt.Name = "dateOfReceipt";
            dateOfReceipt.Size = new Size(184, 27);
            dateOfReceipt.TabIndex = 29;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 4);
            tableLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(818, 104);
            tableLayoutPanel11.TabIndex = 28;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 116);
            tableLayoutPanel12.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(818, 104);
            tableLayoutPanel12.TabIndex = 29;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(tableLayoutPanel11, 0, 0);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel12, 0, 1);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel8, 0, 3);
            tableLayoutPanel14.Location = new Point(99, 32);
            tableLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 4;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.Size = new Size(824, 387);
            tableLayoutPanel14.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 227);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(818, 106);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(printByPrinterButton, 0, 0);
            tableLayoutPanel8.Controls.Add(textToSpeechButton, 3, 0);
            tableLayoutPanel8.Controls.Add(button22345, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 339);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(818, 45);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // printByPrinterButton
            // 
            printByPrinterButton.Anchor = AnchorStyles.Bottom;
            printByPrinterButton.Location = new Point(39, 5);
            printByPrinterButton.Margin = new Padding(3, 4, 3, 4);
            printByPrinterButton.MinimumSize = new Size(126, 36);
            printByPrinterButton.Name = "printByPrinterButton";
            printByPrinterButton.Size = new Size(126, 36);
            printByPrinterButton.TabIndex = 32;
            printByPrinterButton.Text = "Печать";
            printByPrinterButton.UseVisualStyleBackColor = true;
            printByPrinterButton.Click += printByPrinterButton_Click;
            // 
            // textToSpeechButton
            // 
            textToSpeechButton.Anchor = AnchorStyles.Bottom;
            textToSpeechButton.Location = new Point(652, 6);
            textToSpeechButton.MinimumSize = new Size(126, 36);
            textToSpeechButton.Name = "textToSpeechButton";
            textToSpeechButton.Size = new Size(126, 36);
            textToSpeechButton.TabIndex = 35;
            textToSpeechButton.Text = "Озвучить";
            textToSpeechButton.UseVisualStyleBackColor = true;
            textToSpeechButton.Click += textToSpeechButton_Click;
            // 
            // button22345
            // 
            button22345.Location = new Point(207, 3);
            button22345.Name = "button22345";
            button22345.Size = new Size(94, 29);
            button22345.TabIndex = 36;
            button22345.Text = "button1";
            button22345.UseVisualStyleBackColor = true;
            button22345.Click += button22345_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Settings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 28);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // Settings
            // 
            Settings.Name = "Settings";
            Settings.Size = new Size(98, 24);
            Settings.Text = "Настройки";
            Settings.Click += Settings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 419);
            Controls.Add(tableLayoutPanel14);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(941, 466);
            MinimumSize = new Size(941, 466);
            Name = "Form1";
            Text = "АСУ ППО и АСФ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox address;
        private Label label2;
        private TextBox typeOfIncident;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox fio;
        private TextBox number;

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel14;
        private Button printByPrinterButton;
        private TextBox timeHours;
        private TextBox timeMinutes;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private DateTimePicker dateOfReceipt;
        private Button textToSpeechButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Settings;
        private Button button22345;
    }
}