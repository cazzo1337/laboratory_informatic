using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class NewUserAddForm : Form
    {
        FormUsers formUsers;

        public NewUserAddForm(FormUsers formUsers)
        {
            InitializeComponent();

            this.formUsers = formUsers;
        }

        private void NewUserAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            formUsers.AddNewUser(new FormUsers.User(passwordTextBox.Text, loginTextBox.Text, dateTextBox.Value,
                phoneTextBox.Text, emailTextBox.Text, nameTextBox.Text, surnameTextBox.Text));

            Close();
        }
        

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nameTextBox.Text, "[^А-яА-Я]"))
            {
                MessageBox.Show("Можно использовать только русские буквы!");
                nameTextBox.Text = Regex.Replace(nameTextBox.Text, "[^А-яА-Я]", "");
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs args)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно использовать только цифры!");
                phoneTextBox.Text = Regex.Replace(phoneTextBox.Text, "[\\D]", ""); 
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(surnameTextBox.Text, "[^А-яА-Я]"))
            {
                MessageBox.Show("Можно использовать только русские буквы!");
                surnameTextBox.Text = Regex.Replace(surnameTextBox.Text, "[^А-яА-Я]", "");
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(loginTextBox.Text, "[^A-zA-Z-0-9]"))
            {
                MessageBox.Show("Можно использовать только латинские буквы!");
                loginTextBox.Text = Regex.Replace(loginTextBox.Text, "[^A-zA-Z-0-9]", "");
            }
        }
    }
}
