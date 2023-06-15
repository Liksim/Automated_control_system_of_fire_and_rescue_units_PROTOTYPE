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
            ((System.ComponentModel.ISupportInitialize)ButtonsData).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 229);
            addButton.MinimumSize = new Size(100, 50);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 50);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить кнопку";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ButtonName
            // 
            ButtonName.Location = new Point(29, 41);
            ButtonName.Name = "ButtonName";
            ButtonName.Size = new Size(170, 27);
            ButtonName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 2;
            label1.Text = "Надпись на кнопке:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 81);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 3;
            label2.Text = "Текст для озвучивания:";
            // 
            // ButtonVoicing
            // 
            ButtonVoicing.Location = new Point(29, 104);
            ButtonVoicing.Name = "ButtonVoicing";
            ButtonVoicing.Size = new Size(170, 27);
            ButtonVoicing.TabIndex = 4;
            // 
            // ButtonsData
            // 
            ButtonsData.AllowUserToAddRows = false;
            ButtonsData.AllowUserToDeleteRows = false;
            ButtonsData.Anchor = AnchorStyles.Top;
            ButtonsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ButtonsData.Columns.AddRange(new DataGridViewColumn[] { IdColumn, NameColumn, VoicingColumn });
            ButtonsData.Location = new Point(379, 12);
            ButtonsData.Name = "ButtonsData";
            ButtonsData.ReadOnly = true;
            ButtonsData.RowHeadersWidth = 51;
            ButtonsData.RowTemplate.Height = 29;
            ButtonsData.Size = new Size(628, 406);
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
            AddErrorLabel.AutoSize = true;
            AddErrorLabel.ForeColor = Color.Red;
            AddErrorLabel.Location = new Point(22, 281);
            AddErrorLabel.Name = "AddErrorLabel";
            AddErrorLabel.Size = new Size(41, 20);
            AddErrorLabel.TabIndex = 7;
            AddErrorLabel.Text = "Error";
            AddErrorLabel.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(236, 229);
            deleteButton.MinimumSize = new Size(100, 50);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 50);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить кнопку";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // ButtonId
            // 
            ButtonId.Location = new Point(236, 185);
            ButtonId.Name = "ButtonId";
            ButtonId.Size = new Size(100, 27);
            ButtonId.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 162);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 10;
            label3.Text = "ID удаляемой кнопки:";
            // 
            // DeleteErrorLabel
            // 
            DeleteErrorLabel.AutoSize = true;
            DeleteErrorLabel.ForeColor = Color.Red;
            DeleteErrorLabel.Location = new Point(212, 282);
            DeleteErrorLabel.Name = "DeleteErrorLabel";
            DeleteErrorLabel.Size = new Size(41, 20);
            DeleteErrorLabel.TabIndex = 11;
            DeleteErrorLabel.Text = "Error";
            DeleteErrorLabel.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 450);
            Controls.Add(DeleteErrorLabel);
            Controls.Add(label3);
            Controls.Add(ButtonId);
            Controls.Add(deleteButton);
            Controls.Add(AddErrorLabel);
            Controls.Add(ButtonsData);
            Controls.Add(ButtonVoicing);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonName);
            Controls.Add(addButton);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ButtonsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}