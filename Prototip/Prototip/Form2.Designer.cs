﻿using System.Windows.Forms;

namespace Prototip
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            ButtonName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ButtonVoicing = new TextBox();
            ButtonsData = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            VoicingColumn = new DataGridViewTextBoxColumn();
            HotKeyColumn = new DataGridViewTextBoxColumn();
            AddErrorLabel = new Label();
            deleteButton = new Button();
            DeleteErrorLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label4 = new Label();
            hotKeyButton = new Button();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tableLayoutPanel13 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            label7 = new Label();
            tableLayoutPanel14 = new TableLayoutPanel();
            alertLocationButton = new Button();
            alertLocation = new TextBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label6 = new Label();
            departmentName = new TextBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            label5 = new Label();
            districts = new TextBox();
            saveGlobalSettingsButton = new Button();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ButtonsData).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(39, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 32);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить кнопку";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ButtonName
            // 
            ButtonName.Anchor = AnchorStyles.None;
            ButtonName.Location = new Point(29, 44);
            ButtonName.Name = "ButtonName";
            ButtonName.Size = new Size(170, 27);
            ButtonName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 2;
            label1.Text = "Надпись на кнопке:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(29, 9);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 3;
            label2.Text = "Текст для озвучивания:";
            // 
            // ButtonVoicing
            // 
            ButtonVoicing.Anchor = AnchorStyles.None;
            ButtonVoicing.Location = new Point(29, 44);
            ButtonVoicing.Name = "ButtonVoicing";
            ButtonVoicing.Size = new Size(170, 27);
            ButtonVoicing.TabIndex = 4;
            // 
            // ButtonsData
            // 
            ButtonsData.AllowUserToAddRows = false;
            ButtonsData.AllowUserToDeleteRows = false;
            ButtonsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ButtonsData.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, VoicingColumn, HotKeyColumn });
            ButtonsData.Dock = DockStyle.Fill;
            ButtonsData.Location = new Point(243, 3);
            ButtonsData.Name = "ButtonsData";
            ButtonsData.ReadOnly = true;
            ButtonsData.RowHeadersVisible = false;
            ButtonsData.RowHeadersWidth = 51;
            ButtonsData.RowTemplate.Height = 29;
            ButtonsData.Size = new Size(722, 501);
            ButtonsData.TabIndex = 5;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "ID";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.ReadOnly = true;
            IdColumn.Width = 125;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Надпись на кнопке";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 200;
            // 
            // VoicingColumn
            // 
            VoicingColumn.HeaderText = "Текст для озвучивания";
            VoicingColumn.MinimumWidth = 6;
            VoicingColumn.Name = "VoicingColumn";
            VoicingColumn.ReadOnly = true;
            VoicingColumn.Width = 250;
            // 
            // HotKeyColumn
            // 
            HotKeyColumn.HeaderText = "Горячая клавиша";
            HotKeyColumn.MinimumWidth = 6;
            HotKeyColumn.Name = "HotKeyColumn";
            HotKeyColumn.ReadOnly = true;
            HotKeyColumn.Width = 158;
            // 
            // AddErrorLabel
            // 
            AddErrorLabel.Anchor = AnchorStyles.None;
            AddErrorLabel.AutoSize = true;
            AddErrorLabel.ForeColor = Color.Red;
            AddErrorLabel.Location = new Point(93, 47);
            AddErrorLabel.Name = "AddErrorLabel";
            AddErrorLabel.Size = new Size(41, 20);
            AddErrorLabel.TabIndex = 7;
            AddErrorLabel.Text = "Error";
            AddErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            AddErrorLabel.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(39, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 34);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить кнопку";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteErrorLabel
            // 
            DeleteErrorLabel.Anchor = AnchorStyles.None;
            DeleteErrorLabel.AutoSize = true;
            DeleteErrorLabel.ForeColor = Color.Red;
            DeleteErrorLabel.Location = new Point(93, 50);
            DeleteErrorLabel.Name = "DeleteErrorLabel";
            DeleteErrorLabel.Size = new Size(41, 20);
            DeleteErrorLabel.TabIndex = 11;
            DeleteErrorLabel.Text = "Error";
            DeleteErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            DeleteErrorLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonsData, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(968, 507);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel6, 0, 5);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel7.Size = new Size(234, 501);
            tableLayoutPanel7.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(ButtonName, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(228, 77);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(ButtonVoicing, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 86);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(228, 77);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(deleteButton, 0, 0);
            tableLayoutPanel6.Controls.Add(DeleteErrorLabel, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 418);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(228, 80);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(addButton, 0, 0);
            tableLayoutPanel4.Controls.Add(AddErrorLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 252);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(228, 77);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label4, 0, 0);
            tableLayoutPanel8.Controls.Add(hotKeyButton, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 169);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(228, 77);
            tableLayoutPanel8.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(8, 9);
            label4.Name = "label4";
            label4.Size = new Size(212, 20);
            label4.TabIndex = 0;
            label4.Text = "Назначить горячую клавишу:";
            // 
            // hotKeyButton
            // 
            hotKeyButton.Anchor = AnchorStyles.None;
            hotKeyButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            hotKeyButton.Location = new Point(44, 43);
            hotKeyButton.Name = "hotKeyButton";
            hotKeyButton.Size = new Size(140, 29);
            hotKeyButton.TabIndex = 1;
            hotKeyButton.Text = "Выбрать";
            hotKeyButton.UseVisualStyleBackColor = true;
            hotKeyButton.Click += hotKeyButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(982, 546);
            tabControl1.TabIndex = 13;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel13);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(974, 513);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Общие";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel13.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel13.Controls.Add(saveGlobalSettingsButton, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(968, 507);
            tableLayoutPanel13.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel12, 0, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel11, 0, 1);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(802, 501);
            tableLayoutPanel9.TabIndex = 7;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(label7, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel14, 0, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 337);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(796, 161);
            tableLayoutPanel12.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 30);
            label7.Name = "label7";
            label7.Size = new Size(341, 20);
            label7.TabIndex = 5;
            label7.Text = "Расположение аудиофайла звука сирены (.wav)";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel14.Controls.Add(alertLocationButton, 1, 0);
            tableLayoutPanel14.Controls.Add(alertLocation, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 83);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(790, 75);
            tableLayoutPanel14.TabIndex = 6;
            // 
            // alertLocationButton
            // 
            alertLocationButton.Location = new Point(663, 3);
            alertLocationButton.Name = "alertLocationButton";
            alertLocationButton.Size = new Size(119, 27);
            alertLocationButton.TabIndex = 0;
            alertLocationButton.Text = "Выбрать файл";
            alertLocationButton.UseVisualStyleBackColor = true;
            alertLocationButton.Click += alertLocationButton_Click;
            // 
            // alertLocation
            // 
            alertLocation.Dock = DockStyle.Fill;
            alertLocation.Location = new Point(3, 3);
            alertLocation.Name = "alertLocation";
            alertLocation.Size = new Size(654, 27);
            alertLocation.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(label6, 0, 0);
            tableLayoutPanel11.Controls.Add(departmentName, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 170);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(796, 161);
            tableLayoutPanel11.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 30);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 3;
            label6.Text = "Название части:";
            // 
            // departmentName
            // 
            departmentName.Dock = DockStyle.Fill;
            departmentName.Location = new Point(3, 83);
            departmentName.Multiline = true;
            departmentName.Name = "departmentName";
            departmentName.ScrollBars = ScrollBars.Vertical;
            departmentName.Size = new Size(790, 75);
            departmentName.TabIndex = 4;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label5, 0, 0);
            tableLayoutPanel10.Controls.Add(districts, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(796, 161);
            tableLayoutPanel10.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 30);
            label5.Name = "label5";
            label5.Size = new Size(373, 20);
            label5.TabIndex = 1;
            label5.Text = "Районы по умолчанию (перечислить черз запятую):";
            // 
            // districts
            // 
            districts.Dock = DockStyle.Fill;
            districts.Location = new Point(3, 83);
            districts.Name = "districts";
            districts.Size = new Size(790, 27);
            districts.TabIndex = 2;
            // 
            // saveGlobalSettingsButton
            // 
            saveGlobalSettingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveGlobalSettingsButton.Location = new Point(839, 468);
            saveGlobalSettingsButton.Name = "saveGlobalSettingsButton";
            saveGlobalSettingsButton.Size = new Size(126, 36);
            saveGlobalSettingsButton.TabIndex = 0;
            saveGlobalSettingsButton.Text = "Сохранить";
            saveGlobalSettingsButton.UseVisualStyleBackColor = true;
            saveGlobalSettingsButton.Click += saveGlobalSettingsButton_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(974, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Кнопки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(974, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ДПП";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Аудиофайлы|*.wav";
            openFileDialog1.Title = "Выберите файл";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 546);
            Controls.Add(tabControl1);
            MaximumSize = new Size(1000, 593);
            MinimumSize = new Size(1000, 593);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ButtonsData).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private TextBox ButtonName;
        private Label label1;
        private Label label2;
        private TextBox ButtonVoicing;
        private DataGridView ButtonsData;
        private Label AddErrorLabel;
        private Button deleteButton;
        private TextBox ButtonId;
        private Label label3;
        private Label DeleteErrorLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label4;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn VoicingColumn;
        private DataGridViewTextBoxColumn HotKeyColumn;
        private Button hotKeyButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox districts;
        private Label label5;
        private Button saveGlobalSettingsButton;
        private TextBox departmentName;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel14;
        private Button alertLocationButton;
        private TextBox alertLocation;
    }
}