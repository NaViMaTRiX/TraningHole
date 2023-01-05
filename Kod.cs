using System;
using System.Windows.Forms;

namespace Auto
{
    public partial class Kod : Form
    {
        public Kod()
        {
            InitializeComponent();
        }
        readonly Email email = new Email();

        private void cButton1_Click(object sender, EventArgs e)
        {
            if (email.kod == Convert.ToInt32(textBox1.Text))
            {
                MessageBox.Show("Код введён правильно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Password password = new Password();
                password.Show();
                Visible = false;
            }
            else MessageBox.Show("Неправильно введён код! Попробуйте снова ",
                "Неправельный код", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
