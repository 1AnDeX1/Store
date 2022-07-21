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
using static Store.SupplierOfGoods;

namespace Store
{

    public partial class FormSupplier : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;




        public FormSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForAdmin Form1 = new FormForAdmin();
            Form1.Show();

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

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[12, i] = linkCell;
                }
            }
            catch (Exception)
            {

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\учёба\прога\Курсова\Курсова\Store\Store\Database1.mdf;Integrated Security=True");

            sqlConnection.Open();

            LoadData();

            for (int intI = 0; intI < dataGridView1.Rows.Count; intI++)
            {
                for (int intJ = intI + 1; intJ < dataGridView1.RowCount; intJ++)
                {
                    if (dataGridView1.Rows[intJ].Cells[6].Value.ToString() == dataGridView1.Rows[intI].Cells[6].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(intJ);
                        intJ--;
                    }
                }
            }

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }
        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Goods"].Clear();

                sqlDataAdapter.Fill(dataSet, "Goods");

                dataGridView1.DataSource = dataSet.Tables["Goods"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[12, i] = linkCell;
                }
            }
            catch (Exception )
            {

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonChangePhoneNumber_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(textBox1.Text))
                    {
                        if (count == 0)
                        {
                            if (MessageBox.Show($"Change number of {dataGridView1.Rows[i].Cells[6].Value} ?", "Change number", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes)
                            {
                                dataSet.Tables["Goods"].Rows[i]["Supplier phone number"] = textBox2.Text;
                                sqlDataAdapter.Update(dataSet, "Goods");

                                count++;
                            }
                        }
                        else
                        {
                            dataSet.Tables["Goods"].Rows[i]["Supplier phone number"] = textBox2.Text;
                            sqlDataAdapter.Update(dataSet, "Goods");
                        }

                    }
                }

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                
                this.dataGridView1.Columns["Supplier"].Visible = false;
                dataGridView1.Rows[i].Visible = false;
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(textBoxSearch.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }

                }
                
                this.dataGridView1.Columns["Supplier"].Visible = true;
            }
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

