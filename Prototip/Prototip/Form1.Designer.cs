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
            clearAllButton = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            PPDsData = new DataGridView();
            NumberInDepartamentColumn = new DataGridViewTextBoxColumn();
            OrganizationNameColumn = new DataGridViewTextBoxColumn();
            AddressColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
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
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PPDsData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // address
            // 
            address.Dock = DockStyle.Fill;
            address.Location = new Point(3, 105);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(450, 27);
            address.TabIndex = 3;
            address.Text = "сп. Поселение ул. Уличная д. 1111";
            address.GotFocus += addressTextBox_Focus;
            address.LostFocus += addressTextBox_Focus;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 2;
            label2.Text = "Место пожара (ЧС), адрес:";
            // 
            // typeOfIncident
            // 
            typeOfIncident.Dock = DockStyle.Fill;
            typeOfIncident.Location = new Point(3, 105);
            typeOfIncident.Margin = new Padding(3, 4, 3, 4);
            typeOfIncident.Name = "typeOfIncident";
            typeOfIncident.Size = new Size(451, 27);
            typeOfIncident.TabIndex = 5;
            typeOfIncident.Text = "Горит частный дом";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 4;
            label3.Text = "Объект пожара (характер ЧС):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(220, 20);
            label4.TabIndex = 6;
            label4.Text = "Время получения сообщения:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 40);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 12;
            label7.Text = "ФИО заявителя:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 40);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 13;
            label8.Text = "Номер телефона:";
            // 
            // fio
            // 
            fio.Dock = DockStyle.Fill;
            fio.Location = new Point(3, 105);
            fio.Margin = new Padding(3, 4, 3, 4);
            fio.Name = "fio";
            fio.Size = new Size(450, 27);
            fio.TabIndex = 14;
            fio.Text = "Иванов Иван Иванович";
            // 
            // number
            // 
            number.Dock = DockStyle.Fill;
            number.Location = new Point(3, 105);
            number.Margin = new Padding(3, 4, 3, 4);
            number.Name = "number";
            number.Size = new Size(451, 27);
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
            tableLayoutPanel1.Size = new Size(456, 202);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(typeOfIncident, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(495, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(457, 202);
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
            tableLayoutPanel4.Size = new Size(456, 202);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(number, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(495, 4);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(457, 202);
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
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
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
            tableLayoutPanel9.Size = new Size(456, 204);
            tableLayoutPanel9.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(269, 92);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 34;
            label1.Text = ":";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeMinutes
            // 
            timeMinutes.Anchor = AnchorStyles.None;
            timeMinutes.Location = new Point(288, 88);
            timeMinutes.Name = "timeMinutes";
            timeMinutes.Size = new Size(28, 27);
            timeMinutes.TabIndex = 32;
            timeMinutes.Text = "38";
            timeMinutes.TextAlign = HorizontalAlignment.Center;
            // 
            // timeHours
            // 
            timeHours.Anchor = AnchorStyles.None;
            timeHours.Location = new Point(234, 88);
            timeHours.Name = "timeHours";
            timeHours.Size = new Size(28, 27);
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
            tableLayoutPanel10.Location = new Point(495, 4);
            tableLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(457, 204);
            tableLayoutPanel10.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 92);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 28;
            label6.Text = "Дата:";
            // 
            // dateOfReceipt
            // 
            dateOfReceipt.Anchor = AnchorStyles.Left;
            dateOfReceipt.Location = new Point(58, 88);
            dateOfReceipt.Name = "dateOfReceipt";
            dateOfReceipt.Size = new Size(184, 27);
            dateOfReceipt.TabIndex = 29;
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
            tableLayoutPanel11.Size = new Size(955, 210);
            tableLayoutPanel11.TabIndex = 28;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(23, 440);
            tableLayoutPanel12.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(955, 210);
            tableLayoutPanel12.TabIndex = 29;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel12, 1, 3);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel8, 1, 5);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel14.Controls.Add(tableLayoutPanel16, 1, 2);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(0, 28);
            tableLayoutPanel14.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 6;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel14.Size = new Size(1001, 925);
            tableLayoutPanel14.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(23, 657);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(955, 212);
            tableLayoutPanel3.TabIndex = 30;
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
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(23, 875);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(955, 47);
            tableLayoutPanel8.TabIndex = 31;
            // 
            // printByPrinterButton
            // 
            printByPrinterButton.Anchor = AnchorStyles.None;
            printByPrinterButton.Location = new Point(52, 5);
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
            textToSpeechButton.Location = new Point(283, 5);
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
            clearAllButton.Location = new Point(776, 5);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(126, 36);
            clearAllButton.TabIndex = 36;
            clearAllButton.Text = "Очистить всё";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
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
            tableLayoutPanel13.Size = new Size(955, 1);
            tableLayoutPanel13.TabIndex = 32;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(PPDsData, 0, 1);
            tableLayoutPanel16.Controls.Add(label5, 0, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(23, 221);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(955, 212);
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
            PPDsData.Size = new Size(949, 176);
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
            label5.Location = new Point(457, 5);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 33;
            label5.Text = "ДПП";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            menuStrip1.Size = new Size(1001, 28);
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
            ClientSize = new Size(1001, 953);
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
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PPDsData).EndInit();
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
        private TableLayoutPanel tableLayoutPanel13;
        private Button clearAllButton;
        private DataGridView PPDsData;
        private DataGridViewTextBoxColumn NumberInDepartamentColumn;
        private DataGridViewTextBoxColumn OrganizationNameColumn;
        private DataGridViewTextBoxColumn AddressColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label5;
    }
}