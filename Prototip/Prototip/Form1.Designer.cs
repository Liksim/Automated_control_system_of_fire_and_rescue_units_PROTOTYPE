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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            address = new TextBox();
            label2 = new Label();
            typeOfIncident = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            fio = new TextBox();
            number = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            details = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dateOfReceipt = new DateTimePicker();
            label6 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            printByPrinterButton = new Button();
            textToSpeechButton = new Button();
            clearAllButton = new Button();
            mailingButton = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            PPDsData = new DataGridView();
            NumberInDepartamentColumn = new DataGridViewTextBoxColumn();
            OrganizationNameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            Settings = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PPDsData).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // address
            // 
            address.Dock = DockStyle.Fill;
            address.Location = new Point(3, 34);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(463, 27);
            address.TabIndex = 3;
            address.Text = "сп. Поселение ул. Уличная д. 1111";
            address.GotFocus += addressTextBox_Focus;
            address.LostFocus += addressTextBox_Focus;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 2;
            label2.Text = "Место пожара (ЧС), адрес:";
            // 
            // typeOfIncident
            // 
            typeOfIncident.Dock = DockStyle.Fill;
            typeOfIncident.Location = new Point(3, 237);
            typeOfIncident.Margin = new Padding(3, 4, 3, 4);
            typeOfIncident.Name = "typeOfIncident";
            typeOfIncident.Size = new Size(463, 27);
            typeOfIncident.TabIndex = 5;
            typeOfIncident.Text = "Горит частный дом";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 208);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 4;
            label3.Text = "Объект пожара (характер ЧС):";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 5);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 12;
            label7.Text = "ФИО заявителя:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 84);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 13;
            label8.Text = "Номер телефона:";
            // 
            // fio
            // 
            fio.Dock = DockStyle.Fill;
            fio.Location = new Point(3, 34);
            fio.Margin = new Padding(3, 4, 3, 4);
            fio.Name = "fio";
            fio.Size = new Size(464, 27);
            fio.TabIndex = 14;
            fio.Text = "Иванов Иван Иванович";
            // 
            // number
            // 
            number.Dock = DockStyle.Fill;
            number.Location = new Point(3, 113);
            number.Margin = new Padding(3, 4, 3, 4);
            number.Name = "number";
            number.Size = new Size(464, 27);
            number.TabIndex = 15;
            number.Text = "8 800 555 35 35";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(address, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(details, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(typeOfIncident, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(469, 273);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // details
            // 
            details.Dock = DockStyle.Fill;
            details.Location = new Point(3, 103);
            details.Multiline = true;
            details.Name = "details";
            details.ScrollBars = ScrollBars.Vertical;
            details.Size = new Size(463, 97);
            details.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 75);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 5;
            label1.Text = "Дополнительная информация:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(number, 0, 3);
            tableLayoutPanel2.Controls.Add(label8, 0, 2);
            tableLayoutPanel2.Controls.Add(fio, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(508, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(470, 273);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tableLayoutPanel3.Controls.Add(dateOfReceipt, 1, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 235);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(464, 35);
            tableLayoutPanel3.TabIndex = 30;
            // 
            // dateOfReceipt
            // 
            dateOfReceipt.CustomFormat = "H:mm    «dd»MMMMyyyy";
            dateOfReceipt.Dock = DockStyle.Fill;
            dateOfReceipt.Format = DateTimePickerFormat.Custom;
            dateOfReceipt.Location = new Point(237, 3);
            dateOfReceipt.Name = "dateOfReceipt";
            dateOfReceipt.Size = new Size(224, 27);
            dateOfReceipt.TabIndex = 29;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(127, 7);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 28;
            label6.Text = "Время и дата:";
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
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(23, 4);
            tableLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(981, 281);
            tableLayoutPanel11.TabIndex = 28;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel8, 1, 4);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel16, 1, 2);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 28);
            tableLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 6;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Size = new Size(1027, 669);
            tableLayoutPanel14.TabIndex = 31;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 5;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.Controls.Add(printByPrinterButton, 0, 0);
            tableLayoutPanel8.Controls.Add(textToSpeechButton, 1, 0);
            tableLayoutPanel8.Controls.Add(clearAllButton, 4, 0);
            tableLayoutPanel8.Controls.Add(mailingButton, 3, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(23, 601);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(981, 44);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // printByPrinterButton
            // 
            printByPrinterButton.Anchor = AnchorStyles.None;
            printByPrinterButton.Location = new Point(55, 4);
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
            textToSpeechButton.Anchor = AnchorStyles.None;
            textToSpeechButton.BackColor = SystemColors.Window;
            textToSpeechButton.Location = new Point(292, 4);
            textToSpeechButton.MinimumSize = new Size(126, 36);
            textToSpeechButton.Name = "textToSpeechButton";
            textToSpeechButton.Size = new Size(126, 36);
            textToSpeechButton.TabIndex = 35;
            textToSpeechButton.Tag = "Мой тэг";
            textToSpeechButton.Text = "Озвучить";
            textToSpeechButton.UseVisualStyleBackColor = false;
            textToSpeechButton.Click += TextToSpeechButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.Anchor = AnchorStyles.None;
            clearAllButton.Location = new Point(798, 4);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(126, 36);
            clearAllButton.TabIndex = 36;
            clearAllButton.Text = "Очистить всё";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // mailingButton
            // 
            mailingButton.Anchor = AnchorStyles.None;
            mailingButton.Location = new Point(559, 4);
            mailingButton.Name = "mailingButton";
            mailingButton.Size = new Size(126, 36);
            mailingButton.TabIndex = 37;
            mailingButton.Text = "Рассылка";
            mailingButton.UseVisualStyleBackColor = true;
            mailingButton.Click += mailingButton_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(23, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(981, 1);
            tableLayoutPanel13.TabIndex = 32;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(PPDsData, 0, 1);
            tableLayoutPanel16.Controls.Add(label5, 0, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(23, 292);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(981, 283);
            tableLayoutPanel16.TabIndex = 33;
            // 
            // PPDsData
            // 
            PPDsData.AllowUserToAddRows = false;
            PPDsData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PPDsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PPDsData.ColumnHeadersHeight = 29;
            PPDsData.Columns.AddRange(new DataGridViewColumn[] { NumberInDepartamentColumn, OrganizationNameColumn, AddressColumn, TypeColumn });
            PPDsData.Dock = DockStyle.Fill;
            PPDsData.Location = new Point(3, 33);
            PPDsData.Name = "PPDsData";
            PPDsData.ReadOnly = true;
            PPDsData.RowHeadersVisible = false;
            PPDsData.RowHeadersWidth = 51;
            PPDsData.RowTemplate.Height = 29;
            PPDsData.Size = new Size(975, 247);
            PPDsData.TabIndex = 32;
            // 
            // NumberInDepartamentColumn
            // 
            NumberInDepartamentColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            NumberInDepartamentColumn.DefaultCellStyle = dataGridViewCellStyle2;
            NumberInDepartamentColumn.FillWeight = 106.951874F;
            NumberInDepartamentColumn.HeaderText = "№";
            NumberInDepartamentColumn.MinimumWidth = 6;
            NumberInDepartamentColumn.Name = "NumberInDepartamentColumn";
            NumberInDepartamentColumn.ReadOnly = true;
            NumberInDepartamentColumn.Width = 55;
            // 
            // OrganizationNameColumn
            // 
            OrganizationNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrganizationNameColumn.FillWeight = 97.68271F;
            OrganizationNameColumn.HeaderText = "Название организации";
            OrganizationNameColumn.MinimumWidth = 6;
            OrganizationNameColumn.Name = "OrganizationNameColumn";
            OrganizationNameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            AddressColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AddressColumn.DefaultCellStyle = dataGridViewCellStyle3;
            AddressColumn.FillWeight = 97.68271F;
            AddressColumn.HeaderText = "Адрес";
            AddressColumn.MinimumWidth = 6;
            AddressColumn.Name = "AddressColumn";
            AddressColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TypeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            TypeColumn.FillWeight = 120F;
            TypeColumn.HeaderText = "Тип документа";
            TypeColumn.MinimumWidth = 6;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Width = 118;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(470, 5);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 33;
            label5.Text = "ДПП";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Settings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1027, 28);
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
            ClientSize = new Size(1027, 697);
            Controls.Add(tableLayoutPanel14);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "АСУ ППО и АСФ";
            WindowState = FormWindowState.Minimized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PPDsData).EndInit();
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
        private Label label7;
        private Label label8;
        private TextBox fio;
        private TextBox number;

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel14;
        private Button printByPrinterButton;
        private TableLayoutPanel tableLayoutPanel8;
        private DateTimePicker dateOfReceipt;
        private Button textToSpeechButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Settings;
        private TableLayoutPanel tableLayoutPanel13;
        private Button clearAllButton;
        private DataGridView PPDsData;
        private DataGridViewTextBoxColumn NumberInDepartamentColumn;
        private DataGridViewTextBoxColumn OrganizationNameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label5;
        private Button mailingButton;
        private TextBox details;
        private Label label1;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel3;
    }
}