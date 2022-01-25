using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class Available : Form
    {
        public IDatabaseMan dbman;
        public Available()
        {
            InitializeComponent();
        }

        public void BindGrid(string SelectedValue)
        {
            dataGridView1.DataSource = dbman.SelectWhere(SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
