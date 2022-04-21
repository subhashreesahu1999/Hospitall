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

namespace HMSA
{
    public partial class Form1 : Form
    {
        String path = "Data Source=(localdb)\\MSSqlLocalDB; Initial Catalog=hospital12; Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public static string userName { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           

            //       else

            //       {

            //           MessageBox.Show(" username and password incorrect", "login page");

            //       }

            //   }

            //   else

            //   {

            //       MessageBox.Show(" dashboard opening", "login page");

            //   }
            //   this.Hide();
            //           Dashboard db = new Dashboard();
            //          db.Show();
            //}
        }

            
                private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) { }
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = con;
        //        cmd.CommandText = "insert into Register(username,password,confirm_password) " +
        //            "values('" + txtuser.Text + "', '" + txtpass.Text + "', '" + txtCpass.Text + "')";
        //        //cmd.ExecuteNonQuery();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        MessageBox.Show("User has been Registerd");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtuser.Text == txtUserName.Text && txtCpass.Text == txtPassword.Text)
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = con;
            //    cmd.CommandText = "select * from Register where username = '" + txtuser.Text + "'and password = '" + txtpass.Text + "'";
            //    //cmd.ExecuteNonQuery();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds);
            //    SqlDataReader dbr;

            //    con.Open();

            //    dbr = cmd.ExecuteReader();

            //    int count = 0;

            //    while (dbr.Read())

            //    {

            //        count = count + 1;

            //    }

            //    if (count == 1)

            //    {

            //
            //    }

            //    else if (count > 1)

            //    {

            //
            //    }

            //    else

            //    {

            //
            //    }

            //}

            //else

            //{


            //}
            //this.Hide();
            //Dashboard db = new Dashboard();
            //db.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Register(username,password,confirm_password) " +
                    "values('" + txtUser.Text + "', '" + txtPass.Text + "', '" + txtCpass.Text + "')";
                //cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                //string name;
                MessageBox.Show("User has been Registerd");
               
                    panelLogin.Visible = true;
                //panelRegister.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            userName = txtUserName.Text;

            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Register where username = '" + txtUser.Text + "'and password = '" + txtPass.Text + "'";
                //cmd.CommandText = "select * from Register where username = '" + txtUser.Text + "'and password = '" + txtPass.Text + "'";
                //cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    Dashboard db = new Dashboard();
                   db.loginmane = txtUserName.Text;
                    db.Show();
                }
                else
                {
                    MessageBox.Show("Enter correct user name or password");
                }
            }
            else

            {
                MessageBox.Show("Enter user name or password");

            }

        }


    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegister.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            //panelRegister.Visible = false;
        }
    }
    }

