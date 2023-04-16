using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace StockManagementSystem
{
    public partial class searchUC : UserControl
    {
        public bool SeaPerm = true;
        public searchUC()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");

        private void searchUC_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.stockManagementDataSet2.products);
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            bgl.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select productID,productName,productPrice,productStock,productBarcode from products", bgl);
                SqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    if (cmbType.Text == "ID")
                    {
                        if (rd[0].ToString() == txtSearch.Text)
                        {
                            dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                            
                        }
                    }
                    else if (cmbType.Text == "Name")
                    {
                        if (rd[1].ToString().Contains(txtSearch.Text))
                        {
                            dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                    }
                    else if (cmbType.Text == "Price")
                    {
                        if (rd[2].ToString() == txtSearch.Text)
                        {
                            dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                    }
                    else if (cmbType.Text == "Stock")
                    {
                        if (rd[3].ToString() == txtSearch.Text)
                        {
                            dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                    }
                    else if (cmbType.Text == "Barcode")
                    {
                        if (rd[4].ToString() == txtSearch.Text)
                        {
                            dataGridView1.Rows.Add(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error 4xx!");
            }
            bgl.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productsBindingSource1;
            this.productsTableAdapter.Fill(this.stockManagementDataSet2.products);
            dataGridView1.Refresh();
        }
    }
}
