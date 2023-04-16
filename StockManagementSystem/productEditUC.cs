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
namespace StockManagementSystem
{
    public partial class productEditUC : UserControl
    {
        public bool AddPerm = true;
        public bool DelPerm = true;
        public bool UpdPerm = true;


        public productEditUC()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");

        private void productEditUC_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.stockManagementDataSet.products);
        }

        private void chooseIMG_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtProductImage.Text = openFileDialog1.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            choose = dataGridView1.SelectedCells[0].RowIndex;

            string id, name, price, stock, barcode, image;

            id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            price = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            stock = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            barcode = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            image = dataGridView1.Rows[choose].Cells[5].Value.ToString();

            txtProductID.Text = id;
            txtProductName.Text = name;
            txtProductPrice.Text = price;
            txtProductStock.Text = stock;
            txtProductBCode.Text = barcode;
            txtProductImage.Text = image;
            pictureBox1.ImageLocation = image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                if (txtProductBCode.Text != "" && txtProductName.Text != "" && txtProductPrice.Text != "" && txtProductStock.Text != "" && AddPerm == true)
                {

                    SqlCommand cmd = new SqlCommand("insert into products(productName,productPrice,productBarcode,productImage,productStock) values(@a,@s,@d,@f,@g)", bgl);
                    cmd.Parameters.AddWithValue("@a", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@s", txtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@d", txtProductBCode.Text);
                    cmd.Parameters.AddWithValue("@f", txtProductImage.Text);
                    cmd.Parameters.AddWithValue("@g", txtProductStock.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added");

                }
                this.productsTableAdapter.Fill(this.stockManagementDataSet.products);
            }

            catch (Exception)
            {

                MessageBox.Show("Something went wrong!");
            }

            bgl.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                if (DelPerm == true)
                {
                    SqlCommand cmd2 = new SqlCommand("delete from products where productID=@p1", bgl);
                    cmd2.Parameters.AddWithValue("@p1", txtProductID.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Product Removed");
                }
                
                bgl.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong!");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                if(UpdPerm == true)
                {
                    SqlCommand cmd3 = new SqlCommand("update products set productName=@z2,productPrice=@z3,productStock=@z4,productBarcode=@z5,productImage=@z6 where productID=@z1", bgl);
                    cmd3.Parameters.AddWithValue("@z1", txtProductID.Text);
                    cmd3.Parameters.AddWithValue("@z2", txtProductName.Text);
                    cmd3.Parameters.AddWithValue("@z3", txtProductPrice.Text);
                    cmd3.Parameters.AddWithValue("@z4", txtProductStock.Text);
                    cmd3.Parameters.AddWithValue("@z5", txtProductBCode.Text);
                    cmd3.Parameters.AddWithValue("@z6", txtProductImage.Text);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Product Updated");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }

            bgl.Close();
        }
    }
}
