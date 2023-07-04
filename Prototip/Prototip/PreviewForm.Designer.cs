namespace Prototip
{
    partial class PreviewForm
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
            loginLabel = new Label();
            passwordLabel = new Label();
            settingsPasswordLabel = new Label();
            login = new TextBox();
            password = new TextBox();
            settingsPassword = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            actionButton = new Button();
            refreshButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            errorLabel = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            duplicatePasswordLabel = new Label();
            duplicatePassword = new TextBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            duplicateSettingsPasswordLabel = new Label();
            duplicateSettingsPassword = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(162, 8);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(55, 20);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(157, 8);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(65, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Пароль:";
            // 
            // settingsPasswordLabel
            // 
            settingsPasswordLabel.Anchor = AnchorStyles.None;
            settingsPasswordLabel.AutoSize = true;
            settingsPasswordLabel.Location = new Point(108, 0);
            settingsPasswordLabel.Name = "settingsPasswordLabel";
            settingsPasswordLabel.Size = new Size(163, 1);
            settingsPasswordLabel.TabIndex = 2;
            settingsPasswordLabel.Text = "Пароль к настройкам:";
            settingsPasswordLabel.Visible = false;
            // 
            // login
            // 
            login.Dock = DockStyle.Fill;
            login.Location = new Point(3, 40);
            login.Name = "login";
            login.Size = new Size(374, 27);
            login.TabIndex = 1;
            login.Text = "test";
            // 
            // password
            // 
            password.Dock = DockStyle.Fill;
            password.Location = new Point(3, 40);
            password.Name = "password";
            password.Size = new Size(374, 27);
            password.TabIndex = 2;
            password.Text = "password";
            // 
            // settingsPassword
            // 
            settingsPassword.Dock = DockStyle.Fill;
            settingsPassword.Location = new Point(3, 3);
            settingsPassword.Name = "settingsPassword";
            settingsPassword.Size = new Size(374, 27);
            settingsPassword.TabIndex = 4;
            settingsPassword.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(errorLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(426, 253);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(actionButton, 0, 0);
            tableLayoutPanel5.Controls.Add(refreshButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(23, 193);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(380, 44);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // actionButton
            // 
            actionButton.Anchor = AnchorStyles.None;
            actionButton.Location = new Point(14, 4);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(162, 36);
            actionButton.TabIndex = 6;
            actionButton.Text = "Войти";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.None;
            refreshButton.Location = new Point(204, 4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(162, 36);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Регистрация";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(settingsPasswordLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(settingsPassword, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(23, 163);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(380, 1);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(passwordLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(password, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(23, 83);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(380, 74);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(loginLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(login, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(380, 74);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.None;
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(192, 165);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(41, 20);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "Error";
            errorLabel.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(duplicatePasswordLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(duplicatePassword, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(23, 163);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(380, 1);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // duplicatePasswordLabel
            // 
            duplicatePasswordLabel.Anchor = AnchorStyles.None;
            duplicatePasswordLabel.AutoSize = true;
            duplicatePasswordLabel.Location = new Point(119, 0);
            duplicatePasswordLabel.Name = "duplicatePasswordLabel";
            duplicatePasswordLabel.Size = new Size(142, 1);
            duplicatePasswordLabel.TabIndex = 0;
            duplicatePasswordLabel.Text = "Повторите пароль:";
            duplicatePasswordLabel.Visible = false;
            // 
            // duplicatePassword
            // 
            duplicatePassword.Dock = DockStyle.Fill;
            duplicatePassword.Location = new Point(3, 3);
            duplicatePassword.Name = "duplicatePassword";
            duplicatePassword.Size = new Size(374, 27);
            duplicatePassword.TabIndex = 3;
            duplicatePassword.Visible = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(duplicateSettingsPasswordLabel, 0, 0);
            tableLayoutPanel7.Controls.Add(duplicateSettingsPassword, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(23, 163);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(380, 1);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // duplicateSettingsPasswordLabel
            // 
            duplicateSettingsPasswordLabel.Anchor = AnchorStyles.None;
            duplicateSettingsPasswordLabel.AutoSize = true;
            duplicateSettingsPasswordLabel.Location = new Point(70, 0);
            duplicateSettingsPasswordLabel.Name = "duplicateSettingsPasswordLabel";
            duplicateSettingsPasswordLabel.Size = new Size(240, 1);
            duplicateSettingsPasswordLabel.TabIndex = 0;
            duplicateSettingsPasswordLabel.Text = "Повторите пароль к настройкам:";
            duplicateSettingsPasswordLabel.Visible = false;
            // 
            // duplicateSettingsPassword
            // 
            duplicateSettingsPassword.Dock = DockStyle.Fill;
            duplicateSettingsPassword.Location = new Point(3, 3);
            duplicateSettingsPassword.Name = "duplicateSettingsPassword";
            duplicateSettingsPassword.Size = new Size(374, 27);
            duplicateSettingsPassword.TabIndex = 5;
            duplicateSettingsPassword.Visible = false;
            // 
            // PreviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 253);
            Controls.Add(tableLayoutPanel1);
            Name = "PreviewForm";
            Text = "PreviewForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label loginLabel;
        private Label passwordLabel;
        private Label settingsPasswordLabel;
        private TextBox login;
        private TextBox password;
        private TextBox settingsPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button actionButton;
        private Button refreshButton;
        private Label errorLabel;
        private TableLayoutPanel tableLayoutPanel6;
        private Label duplicatePasswordLabel;
        private TextBox duplicatePassword;
        private TableLayoutPanel tableLayoutPanel7;
        private Label duplicateSettingsPasswordLabel;
        private TextBox duplicateSettingsPassword;
    }
}