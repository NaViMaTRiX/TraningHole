using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Auto
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        readonly DataBase dataBase = new DataBase();
        readonly Email email = new Email();

        private void cButton1_Click1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == textBox2.Text)
                {
                    UpdateQuery();
                }
                else MessageBox.Show("Поля должны совпадать!", "Пароли не совподать!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Поля не должны быть пустые!", "Пустые поля!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }




        public void UpdateQuery()
        {
            dataBase.openConnection();
            string querystring = $"Update register set password_user = '{textBox2.Text}' where login_user = '{email.loginU}'";
            SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль был изменём", "Пароль изменён", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*else MessageBox.Show(querystring);*/
            else MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            dataBase.closeConnection();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Kod kod = new Kod();
            kod.Show();
            Visible = false;
        }
    }
}


