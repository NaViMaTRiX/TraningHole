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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add();
            Excel.Worksheet whs = (Excel.Worksheet)excelApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridView1.RowCount - 2; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    whs.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            excelApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Owner = this;
            add.Show();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            string path = "=Traning_Room.mdb";
            Process.Start(path);
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Update(traning_RoomDataSet);
            MessageBox.Show("Изменения сохранены");
        }
    }
}
