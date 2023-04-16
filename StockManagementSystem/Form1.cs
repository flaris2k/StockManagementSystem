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
    public partial class Form1 : Form
    {
        productEditUC pc = new productEditUC();
        searchUC sc = new searchUC();
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            userUC1.Hide();
            searchUC1.Hide();
            productEditUC1.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(sc.SeaPerm == true)
            {
                searchUC1.Show();
                productEditUC1.Hide();
                searchUC1.BringToFront();
            }
            else
            {
                MessageBox.Show("Yetkilendirme Başarısız.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userUC1.Hide();
            searchUC1.Hide();
            productEditUC1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pc.AddPerm == true || pc.DelPerm == true || pc.UpdPerm == true)
            {
                userUC1.Hide();
                searchUC1.Hide();
                productEditUC1.Show();
                productEditUC1.BringToFront();
            }
            else
            {
                MessageBox.Show("Yetkilendirme Başarısız.");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userUC1.Show();
            searchUC1.Hide();
            productEditUC1.Hide();
            userUC1.BringToFront();
        }
    }
}
