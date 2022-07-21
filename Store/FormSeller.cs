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

namespace Store
{
    public partial class FormSeller : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;

        Seller seller = new Seller();

        public FormSeller()
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
        private void FormSeller_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\учёба\прога\Курсова\Курсова\Store\Store\Database1.mdf;Integrated Security=True");

            sqlConnection.Open();

            LoadData();

            for (int intI = 0; intI < dataGridView1.Rows.Count; intI++)
            {
                for (int intJ = intI + 1; intJ < dataGridView1.RowCount; intJ++)
                {
                    if (dataGridView1.Rows[intJ].Cells[8].Value.ToString() == dataGridView1.Rows[intI].Cells[8].Value.ToString())
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
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(textBox1.Text))
                    {

                        if (count == 0)
                        {
                            if (MessageBox.Show($"Dismiss {dataGridView1.Rows[i].Cells[8].Value} ?", "Dismiss", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes)
                            {
                                dataSet.Tables["Goods"].Rows[i]["Seller"] = seller.Null() ;
                                dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = seller.Null();
                                dataSet.Tables["Goods"].Rows[i]["Seller experience"] = seller.Null();
                                sqlDataAdapter.Update(dataSet, "Goods");
                            }
                            count++;
                        }
                        else
                        {
                            dataSet.Tables["Goods"].Rows[i]["Seller"] = seller.Null();
                            dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = seller.Null();
                            dataSet.Tables["Goods"].Rows[i]["Seller experience"] = seller.Null();
                            sqlDataAdapter.Update(dataSet, "Goods");
                        }

                    }
                }

            }
        }
        

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(seller.Null()))
                    {
                        if (count == 0)
                        {
                            dataSet.Tables["Goods"].Rows[i]["Seller"] = textBox2.Text;
                            dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = textBox3.Text;
                            dataSet.Tables["Goods"].Rows[i]["Seller experience"] = textBox4.Text;

                            sqlDataAdapter.Update(dataSet, "Goods");
                            
                            count++;
                        }
                        else
                        {
                            dataSet.Tables["Goods"].Rows[i]["Seller"] = textBox2.Text;
                            dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = textBox3.Text;
                            dataSet.Tables["Goods"].Rows[i]["Seller experience"] = textBox4.Text;

                            sqlDataAdapter.Update(dataSet, "Goods");
                        }
                        
                    }
                    
                }

            }
        }

        private void buttonExperience_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(textBox1.Text))
                    {

                        if (count == 0)
                        {
                            if (MessageBox.Show($"Increase experience of {dataGridView1.Rows[i].Cells[8].Value} ?", "Experience", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes)
                            {
                                dataSet.Tables["Goods"].Rows[i]["Seller experience"] = seller.ExperienceIncrease(Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value));

                                sqlDataAdapter.Update(dataSet, "Goods");

                            }
                            count++;
                        }
                        else
                        {
                            dataSet.Tables["Goods"].Rows[i]["Seller experience"] = seller.ExperienceIncrease(Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value));

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
                this.dataGridView1.Columns["Seller"].Visible = false;
                dataGridView1.Rows[i].Visible = false;
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(textBoxSearch.Text))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
                this.dataGridView1.Columns["Seller"].Visible = true;
            }
        }

       
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}