using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            untext.Text = "";
            passtext.Text = "";
            untext.Focus();
        }

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void loginbutton_Click(object sender, EventArgs e)
        {

            con = new MySqlConnection("server=localhost;user id=root;password =asd13975;database=stock db;allowuservariables=True");
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login WHERE Username='" + untext.Text + "' AND Password='" + passtext.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                StockMain sm = new StockMain();
                sm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış!");
            }

            con.Close();
        }

        private void passtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                loginbutton_Click(sender, e);
        }
    }
}
