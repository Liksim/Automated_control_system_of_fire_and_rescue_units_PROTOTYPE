using System.Windows.Forms;

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
            AddErrorLabel = new Label();
            deleteButton = new Button();
            ButtonId = new TextBox();
            label3 = new Label();
            DeleteErrorLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)ButtonsData).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(19, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 40);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить кнопку";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ButtonName
            // 
            ButtonName.Anchor = AnchorStyles.None;
            ButtonName.Location = new Point(9, 57);
            ButtonName.Name = "ButtonName";
            ButtonName.Size = new Size(170, 27);
            ButtonName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 2;
            label1.Text = "Надпись на кнопке:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 3;
            label2.Text = "Текст для озвучивания:";
            // 
            // ButtonVoicing
            // 
            ButtonVoicing.Anchor = AnchorStyles.None;
            ButtonVoicing.Location = new Point(9, 57);
            ButtonVoicing.Name = "ButtonVoicing";
            ButtonVoicing.Size = new Size(170, 27);
            ButtonVoicing.TabIndex = 4;
            // 
            // ButtonsData
            // 
            ButtonsData.AllowUserToAddRows = false;
            ButtonsData.AllowUserToDeleteRows = false;
            ButtonsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ButtonsData.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, VoicingColumn });
            ButtonsData.Dock = DockStyle.Fill;
            ButtonsData.Location = new Point(203, 3);
            ButtonsData.MaximumSize = new Size(628, 1000);
            ButtonsData.Name = "ButtonsData";
            ButtonsData.ReadOnly = true;
            ButtonsData.RowHeadersWidth = 51;
            ButtonsData.RowTemplate.Height = 29;
            ButtonsData.Size = new Size(628, 507);
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
            // AddErrorLabel
            // 
            AddErrorLabel.Anchor = AnchorStyles.None;
            AddErrorLabel.AutoSize = true;
            AddErrorLabel.ForeColor = Color.Red;
            AddErrorLabel.Location = new Point(73, 61);
            AddErrorLabel.Name = "AddErrorLabel";
            AddErrorLabel.Size = new Size(41, 20);
            AddErrorLabel.TabIndex = 7;
            AddErrorLabel.Text = "Error";
            AddErrorLabel.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(19, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 40);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить кнопку";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ButtonId
            // 
            ButtonId.Anchor = AnchorStyles.None;
            ButtonId.Location = new Point(44, 57);
            ButtonId.Name = "ButtonId";
            ButtonId.Size = new Size(100, 27);
            ButtonId.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(13, 13);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 10;
            label3.Text = "ID удаляемой кнопки:";
            // 
            // DeleteErrorLabel
            // 
            DeleteErrorLabel.Anchor = AnchorStyles.None;
            DeleteErrorLabel.AutoSize = true;
            DeleteErrorLabel.ForeColor = Color.Red;
            DeleteErrorLabel.Location = new Point(73, 62);
            DeleteErrorLabel.Name = "DeleteErrorLabel";
            DeleteErrorLabel.Size = new Size(41, 20);
            DeleteErrorLabel.TabIndex = 11;
            DeleteErrorLabel.Text = "Error";
            DeleteErrorLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonsData, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(834, 513);
            tableLayoutPanel1.TabIndex = 12;
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
            tableLayoutPanel2.Size = new Size(188, 95);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(ButtonVoicing, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 104);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(188, 95);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(addButton, 0, 0);
            tableLayoutPanel4.Controls.Add(AddErrorLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 205);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(188, 95);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(ButtonId, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 306);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(188, 95);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(deleteButton, 0, 0);
            tableLayoutPanel6.Controls.Add(DeleteErrorLabel, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 407);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(188, 97);
            tableLayoutPanel6.TabIndex = 17;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel6, 0, 4);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Size = new Size(194, 507);
            tableLayoutPanel7.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 513);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(852, 560);
            MinimumSize = new Size(852, 560);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ButtonsData).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addButton;
        private TextBox ButtonName;
        private Label label1;
        private Label label2;
        private TextBox ButtonVoicing;
        private DataGridView ButtonsData;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn VoicingColumn;
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
    }
}