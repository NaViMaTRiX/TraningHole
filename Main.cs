using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\calc.exe");
        }

        private void календарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            cal.Show();
            Visible = true;
        }

        private void заметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void инструкторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.ru/video/preview/?filmId=8359240469918067987&from=tabbar&reqid=1614750806643338-1574585667182458448300145-man2-5426-469-man-video-app-ho-0d2-32046&suggest_reqid=149420260157131325409072199296758&text=индивидуальные+упражнения+по+лечебной+суставной+гимнастике");
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Адрес:Грабцевское шоссе, дом 126 Калуга Калужская область 248009 Россия,  E - mail: ktk40@yandex.ru, Телефон: (4842)59 - 71 - 05, (4842)52 - 18 - 27, (4842)52 - 70 - 92,  Факс: (4842)59 - 71 - 05, http://www.ktk40.ru");
        }

        private void наКартеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.ru/maps/?from=api-maps&ll=36.016742%2C54.563996&mode=usermaps&origin=jsapi_2_1_78&um=constructor%3A900af870c7f584d8ca3a5368116f92c33e07f30711b4b6869bcbbb7a249e8ba5&z=11");
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            Visible = false;
        }
    }
}
