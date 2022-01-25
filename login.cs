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
    public partial class login : Form
    {
        IDatabaseMan dbmanager;
        public login()
        {
            InitializeComponent();
            dbmanager = new DatabaseMan();

        }

        private void BindGrid()
        {
            DataTable dt = dbmanager.SelectAll();
            dataGridView1.DataSource = dt;
            cbxDelete.ValueMember = "ID";
            cbxDelete.DisplayMember = "Name";
            cbxDelete.DataSource = dt;
            cbxID.ValueMember = "ID";
            cbxID.DisplayMember = "ID";
            cbxID.DataSource = dt;
            tbxAuthorUpdate.DataBindings.Clear();
            tbxUpdate.DataBindings.Clear();
            tbxEditionUpdate.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
            tbxPriceUpdate.DataBindings.Clear();
            tbxUpdate.DataBindings.Add("Text", dt, "Name");
            tbxAuthorUpdate.DataBindings.Add("Text", dt, "Author");
            tbxEditionUpdate.DataBindings.Add("Text", dt, "Edition");
            dateTimePicker2.DataBindings.Add("Text", dt, "DatePublished");
            tbxPriceUpdate.DataBindings.Add("Text", dt, "Price");
            BindComboBox();
        }

        private void BindComboBox()
        {
            dbmanager.SelectDistinct();
            cbxAvail.ValueMember = "Name";
            cbxAvail.DisplayMember = "Name";
            cbxAvail.DataSource = dbmanager.SelectDistinct();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                dbmanager.Insert(tbxInsert.Text, tbxAuthor.Text, tbxEdition.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), tbxPrice.Text);
                BindGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                
                dbmanager.Update(tbxUpdate.Text, tbxAuthorUpdate.Text, tbxEditionUpdate.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), tbxPriceUpdate.Text, cbxID.SelectedValue.ToString());
                BindGrid();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbmanager.Delete(cbxDelete.SelectedValue.ToString());
            BindGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbxCopies.Text = dbmanager.SelectCount(cbxAvail.SelectedValue.ToString());
            Available av = new Available();
            av.dbman = dbmanager;
            av.BindGrid(cbxAvail.SelectedValue.ToString());
            av.ShowDialog();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            dbmanager.CloseDb();
            toolStripStatusLabel1.Text = "Disconnected!";
            btnDisconnect.Visible = false;
            btnConnect.Visible = true;
            MessageBox.Show("Connection Closed!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Connecting...";
            bool connected = dbmanager.ConnectDb(tbxServer.Text, tbxPort.Text); 
            toolStripStatusLabel1.Text = connected? "Database Connected!" : "Disconnected!";
            groupBox1.Enabled = connected;
            groupBox2.Enabled = connected;
            groupBox3.Enabled = connected;
            groupBox4.Enabled = connected;
            if (connected)
            {
                BindGrid();
                btnDisconnect.Visible = true;
                btnConnect.Visible = false;
            }
        }

        private void tbxPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPrice.Text))
            {
                e.Cancel = true;
                tbxPriceUpdate.Select(0, tbxPriceUpdate.Text.Length);
                errorProvider1.SetError(tbxPrice, "Price should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbxPrice, "");
            }
        }

        private void tbxPriceUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPriceUpdate.Text))
            {
                
                e.Cancel = true;
                tbxPriceUpdate.Select(0, tbxPriceUpdate.Text.Length);
                errorProvider2.SetError(tbxPriceUpdate, "Price should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(tbxPriceUpdate, "");
            }
        }
    }
}
