using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Auto
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidhtEllipse,
                int nHeightEllipse
            );

        DataBase database = new DataBase();
        SqlDataAdapter adapter = new SqlDataAdapter();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Width, 30, 30));
            textBox_password.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            captcha();
            textBox_password.MaxLength = 50;
            textBox_login.MaxLength = 50;
            this.ActiveControl = label1;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select login_user, password_user from register where login_user = '{textBox_login.Text}' and password_user = '{textBox_password.Text}'";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand= command;
            adapter.Fill(table);
            database.openConnection();
            if (Ibcaptcha.Text == txtcaptch.Text)
            {
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 f = new Form3();
                    f.Show();
                    Visible = false;
                }
                else
                {
                    /*MessageBox.Show("Вы не правильно ввели почту или пароль", "Аккаунт не существует!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
                    MessageBox.Show(query);
                }
            }
            else
            {
                MessageBox.Show("Капча введена не правильно!", "Неправильная капча", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                captcha();
            }
            database.closeConnection();
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            captcha();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email email = new Email();
            email.Show();
            Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.ForeColor = Color.Black;
            textBox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_password.ForeColor = Color.Black;
            textBox_password.UseSystemPasswordChar = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pass = textBox_password.Text;
            if(pass.Length <= 8)
            {
                
            }
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            if(textBox_login.Text == "example@mail.ru")
            {
                textBox_login.Text = "";
                textBox_login.ForeColor = Color.Black;
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

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Более 8 символов")
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                textBox_password.UseSystemPasswordChar = true;
                textBox_password.Text = "";
                textBox_password.ForeColor = Color.Black;
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
