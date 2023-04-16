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
    public partial class userUC : UserControl
    {
        bool panel;
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
        public userUC()
        {
            InitializeComponent();
        }

        private void userUC_Load(object sender, EventArgs e)
        {
            panel = false;
            txtUserid.Text = dataGetSet.Userid;
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from users where userID=@p1",bgl);
            cmd.Parameters.AddWithValue("@p1", txtUserid.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                txtUsername.Text = String.Format("Username : {0}", rd[1].ToString());
                txtEmail.Text = String.Format("Email : {0}", rd[4].ToString());
                txtUserType.Text = String.Format("User Type : {0}", rd[3].ToString());
            }
            

            bgl.Close();
            
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (panel == false)
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chgPasswordBTN_Click(object sender, EventArgs e)
        {
            bgl.Open();
            

            SqlCommand cmd3 = new SqlCommand("update users set userPass=@b2 where userID=@b1",bgl);
            cmd3.Parameters.AddWithValue("@b1", txtUserid.Text);
            if (oldPasswordTB.Text == dataGetSet.Userpass && newPasswordTB.Text == newPasswordTB2.Text)
            {
                cmd3.Parameters.AddWithValue("@b2", newPasswordTB.Text);
                MessageBox.Show("Success!");
                cmd3.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
            bgl.Close();
        }
    }
}
