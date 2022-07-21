using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static Store.Goods;
using static Store.ManufacturerOfGoods;
using static Store.Sellers;
using static Store.SupplierOfGoods;

namespace Store
{
    public partial class FormForAdmin : Form 
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;       
        private DataSet dataSet = null;

        private bool newRowAdding = false;
       
        public FormForAdmin()
        {
            InitializeComponent();

            
        }

        

        
        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Command] FROM Goods", sqlConnection);

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
            catch (Exception )
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;

            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\учёба\прога\Курсова\Курсова\Store\Store\Database1.mdf;Integrated Security=True");

            sqlConnection.Open();

            LoadData();

            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
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

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[12, i] = linkCell;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonManufacturerInfo_Click(object sender, EventArgs e)
        {            
            this.Hide();
            
            FormManufacturer Form2 = new FormManufacturer();
            Form2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
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
                                dataSet.Tables["Goods"].Rows[i]["Seller"] = " ";
                                dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = " ";
                                dataSet.Tables["Goods"].Rows[i]["Seller experience"] = " ";
                                sqlDataAdapter.Update(dataSet, "Goods");
                            }
                            count++;
                        }
                        else
                        {
                            dataSet.Tables["Goods"].Rows[i]["Seller"] = " ";
                            dataSet.Tables["Goods"].Rows[i]["Seller phone number"] = " ";
                            dataSet.Tables["Goods"].Rows[i]["Seller experience"] = " ";
                            sqlDataAdapter.Update(dataSet, "Goods");
                        }               
                        
                    }                   
                }
                
            }
            
        }

        

        

        private void buttonSell_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            int position = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[position].Cells[11].Value = seller.Sell(Convert.ToInt32(dataGridView1.Rows[position].Cells[11].Value), Convert.ToInt32(textBoxValueChange.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierOfGood supplierOfGoods = new SupplierOfGood();

            int position = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[position].Cells[11].Value = supplierOfGoods.Buy(Convert.ToInt32(dataGridView1.Rows[position].Cells[11].Value), Convert.ToInt32(textBoxValueChange.Text));
        }

        private void buttonSupplierInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
        }
        public static string[] clients;
        private void buttonSellerInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeller formSeller = new FormSeller();
            formSeller.Owner = this;
            formSeller.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                if (e.ColumnIndex == 12)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Delete the row?", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                         == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["Goods"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Goods");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;
                        DataRow row = dataSet.Tables["Goods"].NewRow();

                        row["Name"] = dataGridView1.Rows[rowIndex].Cells["Name"].Value;
                        row["Price"] = dataGridView1.Rows[rowIndex].Cells["Price"].Value;
                        row["Manufacturer"] = dataGridView1.Rows[rowIndex].Cells["Manufacturer"].Value;
                        row["Manufacturer phone number"] = dataGridView1.Rows[rowIndex].Cells["Manufacturer phone number"].Value;
                        row["Manufacturer location"] = dataGridView1.Rows[rowIndex].Cells["Manufacturer location"].Value;
                        row["Supplier"] = dataGridView1.Rows[rowIndex].Cells["Supplier"].Value;
                        row["Supplier phone number"] = dataGridView1.Rows[rowIndex].Cells["Supplier phone number"].Value;
                        row["Seller"] = dataGridView1.Rows[rowIndex].Cells["Seller"].Value;
                        row["Seller phone number"] = dataGridView1.Rows[rowIndex].Cells["Seller phone number"].Value;
                        row["Seller experience"] = dataGridView1.Rows[rowIndex].Cells["Seller experience"].Value;
                        row["Amount"] = dataGridView1.Rows[rowIndex].Cells["Amount"].Value;

                        dataSet.Tables["Goods"].Rows.Add(row);
                        dataSet.Tables["Goods"].Rows.RemoveAt(dataSet.Tables["Goods"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataGridView1.Rows[e.RowIndex].Cells[12].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Goods");

                        newRowAdding = false;

                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Goods"].Rows[r]["Name"] = dataGridView1.Rows[r].Cells["Name"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Price"] = dataGridView1.Rows[r].Cells["Price"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Manufacturer"] = dataGridView1.Rows[r].Cells["Manufacturer"].Value;                        
                        dataSet.Tables["Goods"].Rows[r]["Manufacturer phone number"] = dataGridView1.Rows[r].Cells["Manufacturer phone number"].Value;                        
                        dataSet.Tables["Goods"].Rows[r]["Manufacturer location"] = dataGridView1.Rows[r].Cells["Manufacturer location"].Value;                        
                        dataSet.Tables["Goods"].Rows[r]["Supplier"] = dataGridView1.Rows[r].Cells["Supplier"].Value;                    
                        dataSet.Tables["Goods"].Rows[r]["Supplier phone number"] = dataGridView1.Rows[r].Cells["Supplier phone number"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Seller"] = dataGridView1.Rows[r].Cells["Seller"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Seller phone number"] = dataGridView1.Rows[r].Cells["Seller phone number"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Seller experience"] = dataGridView1.Rows[r].Cells["Seller experience"].Value;
                        dataSet.Tables["Goods"].Rows[r]["Amount"] = dataGridView1.Rows[r].Cells["Amount"].Value;

                        sqlDataAdapter.Update(dataSet, "Goods");

                        dataGridView1.Rows[e.RowIndex].Cells[12].Value = "Delete";
                    }
                    ReloadData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[12, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[12, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 11)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Good goods = new Good();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBox2.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Price"] = goods.NewPrice(Convert.ToDouble(textBox3.Text));
                        
                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }

            }
            
        }

        private void buttonGood_Click(object sender, EventArgs e)
        {
            Good goods = new Good();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxGood.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Name"] = goods.Mark(dataGridView1.Rows[i].Cells[1].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonMinusGood_Click(object sender, EventArgs e)
        {
            Good goods = new Good();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(textBoxGood.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Name"] = goods.UnMark(dataGridView1.Rows[i].Cells[1].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonManufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerOfGood manufacturerOfGood = new ManufacturerOfGood();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(textBoxManufacturer.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Manufacturer"] = manufacturerOfGood.Mark(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        
                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonMinusManufacturer_Click(object sender, EventArgs e)
        {
            ManufacturerOfGood manufacturerOfGood = new ManufacturerOfGood();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(textBoxManufacturer.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Manufacturer"] = manufacturerOfGood.UnMark(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        
                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SupplierOfGood supplierOfGood = new SupplierOfGood();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(textBoxSupplier.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Supplier"] = supplierOfGood.Mark(dataGridView1.Rows[i].Cells[6].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonMinusSupplier_Click(object sender, EventArgs e)
        {
            SupplierOfGood supplierOfGood = new SupplierOfGood();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value.ToString().Contains(textBoxSupplier.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Supplier"] = supplierOfGood.UnMark(dataGridView1.Rows[i].Cells[6].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(textBoxSeller.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Seller"] = seller.Mark(dataGridView1.Rows[i].Cells[8].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
        }

        private void buttonMinusSeller_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                if (dataGridView1.Rows[i].Cells[8].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString().Contains(textBoxSeller.Text))
                    {
                        dataSet.Tables["Goods"].Rows[i]["Seller"] = seller.UnMark(dataGridView1.Rows[i].Cells[8].Value.ToString());

                        sqlDataAdapter.Update(dataSet, "Goods");
                        break;
                    }
                }
            }
            
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormPassword formPassword = new FormPassword();
            formPassword.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
