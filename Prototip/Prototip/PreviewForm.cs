using Prototip.DBconnection;
using Prototip.DBconnection.Entities;

namespace Prototip
{
    public partial class PreviewForm : Form
    {
        Repository<Department> departmentRepository = new Repository<Department>(ContextManager.GetContext());

        public PreviewForm()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (refreshButton.Text == "Регистрация")
            {
                duplicatePasswordLabel.Visible = true;
                duplicatePassword.Visible = true;
                settingsPasswordLabel.Visible = true;
                settingsPassword.Visible = true;
                duplicateSettingsPasswordLabel.Visible = true;
                duplicateSettingsPassword.Visible = true;
                actionButton.Text = "Зарегистрироваться";
                refreshButton.Text = "Авторизация";
                tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Absolute, 80F);
                tableLayoutPanel1.RowStyles[3] = new RowStyle(SizeType.Absolute, 80F);
                tableLayoutPanel1.RowStyles[4] = new RowStyle(SizeType.Absolute, 80F);
                Size = new Size(444, 540);
                MaximumSize = new Size(444, 540);
                MinimumSize = new Size(444, 540);
            }
            else if (refreshButton.Text == "Авторизация")
            {
                duplicatePasswordLabel.Visible = false;
                duplicatePassword.Visible = false;
                settingsPasswordLabel.Visible = false;
                settingsPassword.Visible = false;
                duplicateSettingsPasswordLabel.Visible = false;
                duplicateSettingsPassword.Visible = false;
                actionButton.Text = "Войти";
                refreshButton.Text = "Регистрация";
                tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Absolute, 0F);
                tableLayoutPanel1.RowStyles[3] = new RowStyle(SizeType.Absolute, 0F);
                tableLayoutPanel1.RowStyles[4] = new RowStyle(SizeType.Absolute, 0F);
                Size = new Size(444, 300);
                MaximumSize = new Size(444, 300);
                MinimumSize = new Size(444, 300);
            }
            errorLabel.Visible = false;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            var departments = departmentRepository.Read().ToList();

            if (actionButton.Text == "Войти")
            {
                if (login.Text == "" || password.Text == "")
                {
                    errorLabel.Text = "Все поля должны быть заполнены!";
                    errorLabel.Visible = true;
                    return;
                }

                foreach (var department in departments)
                {
                    if (department.Login == login.Text && department.Password == password.Text)
                    {
                        Form1 mainForm = new Form1(this, department.Id);
                        mainForm.ShowDialog();
                        Close();
                        return;
                    }
                }

                errorLabel.Text = "Неверный логин и/или пароль!";
                errorLabel.Visible = true;
            }
            else if (actionButton.Text == "Зарегистрироваться")
            {
                if (login.Text == "" ||
                    password.Text == "" ||
                    duplicatePassword.Text == "" ||
                    settingsPassword.Text == "" ||
                    duplicateSettingsPassword.Text == "")
                {
                    errorLabel.Text = "Все поля должны быть заполнены!";
                    errorLabel.Visible = true;
                    return;
                }

                foreach (var department in departments)
                {
                    if (department.Login == login.Text)
                    {
                        errorLabel.Text = "Такой логин уже существует!";
                        errorLabel.Visible = true;
                        return;
                    }
                }

                if (password.Text.Length < 5 || settingsPassword.Text.Length < 5)
                {
                    errorLabel.Text = "Пароль должен содержать более 4 символов!";
                    errorLabel.Visible = true;
                    return;
                }

                if (password.Text != duplicatePassword.Text)
                {
                    errorLabel.Text = "Пароли не совпадают!";
                    errorLabel.Visible = true;
                    return;
                }

                if (settingsPassword.Text != duplicateSettingsPassword.Text)
                {
                    errorLabel.Text = "Пароли для настроек не совпадают!";
                    errorLabel.Visible = true;
                    return;
                }

                Department newDepartment = new Department
                {
                    Login = login.Text,
                    Password = password.Text,
                    SettingsPassword = settingsPassword.Text
                };

                departmentRepository.Create(newDepartment);

                Form1 mainForm = new Form1(this, newDepartment.Id);
                mainForm.ShowDialog();
                Close();
            }
        }
    }
}
