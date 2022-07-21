using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Store.Sellers;
using static Store.SupplierOfGoods;

namespace Store
{
    public partial class FormForSeller : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        public FormForSeller()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Goods", sqlConnection);

                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Goods");

                dataGridView1.DataSource = dataSet.Tables["Goods"];

                
            }
            catch (Exception)
            {

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormForSeller_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\учёба\прога\Курсова\Курсова\Store\Store\Database1.mdf;Integrated Security=True");

            sqlConnection.Open();

            LoadData();

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }
        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Goods"].Clear();

                sqlDataAdapter.Fill(dataSet, "Goods");

                dataGridView1.DataSource = dataSet.Tables["Goods"];

                
            }
            catch (Exception )
            {

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            int position = dataGridView1.CurrentRow.Index;
            
            dataSet.Tables["Goods"].Rows[position]["Amount"] = seller.Sell(Convert.ToInt32(dataGridView1.Rows[position].Cells[11].Value), Convert.ToInt32(textBoxValueChange.Text));

            sqlDataAdapter.Update(dataSet, "Goods");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierOfGood supplierOfGoods = new SupplierOfGood();

            int position = dataGridView1.CurrentRow.Index;
            dataSet.Tables["Goods"].Rows[position]["Amount"] = supplierOfGoods.Buy(Convert.ToInt32(dataGridView1.Rows[position].Cells[11].Value), Convert.ToInt32(textBoxValueChange.Text));
            sqlDataAdapter.Update(dataSet, "Goods");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Rows[i].Visible = false;
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxSearch.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }

                }
                this.dataGridView1.Columns["Id"].Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPassword formPassword = new FormPassword();
            formPassword.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
