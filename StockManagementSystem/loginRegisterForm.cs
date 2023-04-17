using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace StockManagementSystem
{
    public partial class loginRegisterForm : Form
    {
        
        private bool LoginPage = true;
        public loginRegisterForm()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-6D2H8GE\\SQLEXPRESS;Initial Catalog=StockManagement;Integrated Security=True");
        private void loginRegisterForm_Load(object sender, EventArgs e)
        {
            registerUC1.Hide();
            
        }
        private void loginUC1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            if (LoginPage == true) 
            {
                SqlCommand cmd = new SqlCommand("select userID,userName,userPass,userType from users", bgl);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (loginUC1.txtUsername.Text == rd[1].ToString() && loginUC1.txtPassword.Text == rd[2].ToString())
                    {
                        dataGetSet.Userid = rd[0].ToString();
                        dataGetSet.Userpass = rd[2].ToString();
                        dataGetSet.Usertype = rd[3].ToString();
                        /*Form1 mainpage = new Form1();
                        mainpage.Show();
                        this.Close();*/
                        Thread th = new Thread(onw);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Close();
                        
                    }
                }
            }
            else
            {
                LoginPage = true;
                registerUC1.Hide();
                loginUC1.Show();
            }  
            bgl.Close();
        }
        private void onw()
        {
            Application.Run(new Form1());
        }
        private void BTNregister_Click(object sender, EventArgs e)
        {
            string userType = "personel";
            if (registerUC1.txtSC.Text == "797797") 
            {
                userType = "admin";
            }
            bgl.Open();
            if (LoginPage == true) 
            {
                LoginPage = false;
                registerUC1.Show();
                loginUC1.Hide();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into users(userName,userPass,userType,userMail) values(@p1,@p2,@p3,@p4)", bgl);
                    cmd.Parameters.AddWithValue("@p1", registerUC1.txtUsername.Text);
                    cmd.Parameters.AddWithValue("@p2", registerUC1.txtPassword.Text);
                    cmd.Parameters.AddWithValue("@p3", userType);
                    cmd.Parameters.AddWithValue("@p4", registerUC1.txtEmail.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success");

                }
                catch (Exception)
                {

                    MessageBox.Show("Something went wrong!");
                }
            }  
            bgl.Close();
        }
    }
}
