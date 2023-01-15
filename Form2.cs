using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Auto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            textBox_password.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            captcha();
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
        }
        private void captcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || chr >= 97 && chr <= 122)
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                        break;
                    {

                    }
                }
            } while (true);
            Ibcaptcha.Text = captcha;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            var login = textBox_login.Text;
            var password = textBox_password.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (Ibcaptcha.Text != txtcaptch.Text)
            {
                MessageBox.Show("Капча введена не правильно!", "Неправильная капча", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                captcha();
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f = new Form3();
                f.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!!", "Не создан", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                captcha();
            }
            dataBase.closeConnection();
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            captcha();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Visible = false;
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            if (textBox_login.Text == "example@mail.ru")
            {
                textBox_login.Text = "";
                textBox_login.ForeColor = Color.Black;
            }
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Более 8 символов")
            {
                this.Focus();
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                textBox_password.UseSystemPasswordChar = true;
                textBox_password.Text = "";
                textBox_password.ForeColor = Color.Black;
            }
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            if (textBox_login.Text == "")
            {
                textBox_login.Text = "example@mail.ru";
                textBox_login.ForeColor = Color.Gray;
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == "")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                textBox_password.UseSystemPasswordChar = false;
                textBox_password.Text = "Более 8 символов";
                textBox_password.ForeColor = Color.Gray;
            }
        }
    }
}
