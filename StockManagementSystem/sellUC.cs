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

namespace StockManagementSystem
{
    public partial class sellUC : UserControl
    {
        bool DelPerm = true;
        public sellUC()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            bgl.Open();
            
            try
            {
                
                if (DelPerm == true)
                {
                    
                    SqlCommand cmd2 = new SqlCommand("update products set productStock=productStock-@p2 where productID=@p1", bgl);
                    cmd2.Parameters.AddWithValue("@p1", txtProductID.Text);
                    cmd2.Parameters.AddWithValue("@p2", Convert.ToInt32(txtProductStock.Text));
                    cmd2.ExecuteNonQuery();

                    double profit = Convert.ToDouble(txtProductStock.Text) * Convert.ToDouble(txtProductSPrice.Text);
                    label8.Text = Convert.ToString(profit);
                    label8.Text = String.Format("+{0:n}", double.Parse(label8.Text));

                    SqlCommand cmdd = new SqlCommand("insert into process(processType,processAmount,processDate) values(@c1,@c2,@c3)", bgl);
                    cmdd.Parameters.AddWithValue("@c1", "sell");
                    cmdd.Parameters.AddWithValue("@c2", profit);
                    cmdd.Parameters.AddWithValue("@c3", cmbDate.Text);
                    cmdd.ExecuteNonQuery();
                    dbRefresh();
                    MessageBox.Show("Product Sold!");
                }
                


            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong!");
            }
            bgl.Close();

        }

        private void sellUC_Load(object sender, EventArgs e)
        {
            bgl.Open();
            dbRefresh();

        }
        private void dbRefresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            SqlCommand cmdfilter = new SqlCommand("select * from products",bgl);
            SqlDataReader red = cmdfilter.ExecuteReader();

            while (red.Read())
            {
                if (Convert.ToInt32(red[4]) > 0)
                {
                    dataGridView1.Rows.Add(red[0].ToString(), red[1].ToString(), red[2].ToString(), red[3].ToString(), red[4].ToString(), red[5].ToString(), red[6].ToString());
                }
            }
            bgl.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;

            string id, name, bprice, stock, barcode, image, sprice;

            id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            bprice = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            sprice = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            stock = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            barcode = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            image = dataGridView1.Rows[choose].Cells[6].Value.ToString();

            txtProductID.Text = id;
            txtProductName.Text = name;
            txtProductSPrice.Text = sprice;
            txtProductBPrice.Text = bprice;
            txtProductStock.Text = stock;
            txtProductBCode.Text = barcode;
            txtProductImage.Text = image;
            pictureBox1.ImageLocation = image;
        }
    }
}

