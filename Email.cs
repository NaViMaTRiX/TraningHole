using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Auto
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        DataBase database = new DataBase();
        public static string loginUser;
        public string loginU = loginUser;
        private void cButton1_Click(object sender, EventArgs e)
        {
            loginUser = textBox1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select login_user from register where login_user = '{loginUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Мы успешно нашли вашу почту", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailAddress from = new MailAddress("flniver2016@gmail.com");
                MailAddress to = new MailAddress(textBox1.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Код востановления";
                m.Body = "<h2>Здравствуйте Вы отправили запрос на восстановление пароля?" +
                    "Код Востановления :</h2>" + kodr + ". Кто-то (надеемся, что вы) попросил нас сбросить пароль для вашей учетной записи Трекон. Чтобы сделать это, " +
                    "щелкните по кнопке ниже. Если вы не запрашивали сброс пароля, игнорируйте это сообщение!";
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("flniver2016@gmail.com", "mrkefihdmchahkjp");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Письмо отправлено", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kod kod = new Kod();
                kod.Show();
                Visible = false;
            }
            else MessageBox.Show("Мы не нашли вашу почту! Проверьте корректность введённых данных и попробуйте cнова", 
                "Неправельный логин", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public string login()
        {
            return loginUser;
        }

        private static int random()
        {
            Random rnd = new Random();
            int rernd;
            rernd = rnd.Next(100000, 999999);
            return rernd;
        }
        public static int kodr = random();
        public int kod = kodr;

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }
    }
}
