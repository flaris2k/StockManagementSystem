using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    
    public partial class buyUC : UserControl
    {
        public buyUC()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
        bool AddPerm = true;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bgl.Open();
            try
            {
                if (txtProductBCode.Text != "" && txtProductName.Text != "" && txtProductSPrice.Text != "" && txtProductStock.Text != "" && AddPerm == true)
                {

                    

                    SqlCommand cmd = new SqlCommand("insert into products(productName,productBPrice,productBarcode,productImage,productStock,productSPrice) values(@a,@s,@d,@f,@g,@h)", bgl);
                    cmd.Parameters.AddWithValue("@a", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@s", txtProductBPrice.Text);
                    cmd.Parameters.AddWithValue("@h", txtProductSPrice.Text);
                    cmd.Parameters.AddWithValue("@d", txtProductBCode.Text);
                    cmd.Parameters.AddWithValue("@f", txtProductImage.Text);
                    cmd.Parameters.AddWithValue("@g", txtProductStock.Text);
                    cmd.ExecuteNonQuery();

                    double profit = Convert.ToDouble(txtProductBPrice.Text) * Convert.ToDouble(txtProductStock.Text);
                    label8.Text = Convert.ToString(profit);
                    label8.Text = string.Format("-{0:n}", double.Parse(label8.Text));


                    SqlCommand cmdpro = new SqlCommand("insert into process(processType,processAmount,processDate),values(@a1,@a2,@a3)", bgl);
                    cmdpro.Parameters.AddWithValue("@a1", "buy");
                    cmdpro.Parameters.AddWithValue("@a2", profit);
                    cmdpro.Parameters.AddWithValue("@a3", cmbDate.Text);
                    cmdpro.ExecuteNonQuery();


                    MessageBox.Show("Product Added");


                }
                this.productsTableAdapter.Fill(this.stockManagementDataSet6.products);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!");
            }
            bgl.Close();
        }

        private void buyUC_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.stockManagementDataSet6.products);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
