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
    public partial class Customer : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=asd13975;database=stock db;allowuservariables=True");
        public Customer()
        {
            InitializeComponent();
        }


        private bool validation()
        {
            if (string.IsNullOrEmpty(cidtext.Text) || string.IsNullOrEmpty(cnametext.Text) || string.IsNullOrEmpty(adrestext.Text))
                return false;
            return true;
        }

        private void cnametext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cidtext_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
                e.Handled = true;
            
        }
        private void ResetRecords()
        {
            cnametext.Clear();
            cidtext.Clear();
            adrestext.Clear();

            addbutton.Text = "Add";
            cidtext.Focus();
        }

        

        private void resetbutton_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private void cidtext_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cidtext.Text)) return;

            int pcode = Convert.ToInt32(cidtext.Text);

            if (ifCustomerExist())
                addbutton.Text = "Update";
            else { addbutton.Text = "Add"; }
        }
        private void LoadData()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM Customer ", con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private bool ifCustomerExist()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM Customer WHERE Customer_id='" + cidtext.Text + "'", con);
            DataTable dt = new DataTable();
            msda.Fill(dt);


            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (!validation()) { MessageBox.Show("Fields Can't Be Empty!"); return; }

            string cid = cidtext.Text;
            string cname = cnametext.Text;
            string adres = adrestext.Text;

            string sqlquery;
            if (ifCustomerExist())
            {
                sqlquery = "UPDATE Customer SET CustomerName = '" + cname + "', Address = '" + adres + "' WHERE Customer_Id = '"+cid+"'";
            }
            else
            {
                sqlquery = "INSERT INTO Customer VALUES ('"+cid+"','" + cname + "','" + adres + "')";
            }
            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlquery;
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Record Saved Successfully");
            ResetRecords();

        }

        private bool checkSales()
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT * FROM Sale WHERE Customer_Id='" + cidtext.Text + "'", con);
            DataTable dt = new DataTable();
            msda.Fill(dt);


            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void deletebuttın_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cidtext.Text)) { MessageBox.Show("Customer Id Can!t Be Empty!"); return; }

            if (checkSales())
            {
                DialogResult dre = MessageBox.Show("If You Delete This Item, Data That in The Sale Table Will Be Lost ! Are You Sure To Delete This Item?  ", "Message", MessageBoxButtons.YesNo);
                if (dre == DialogResult.No) return;

            }
            else
            {
                DialogResult dre = MessageBox.Show("Are You Sure To Delete This Item?  ", "Message", MessageBoxButtons.YesNo);
                if (dre == DialogResult.No) return;
            }

            MySqlCommand cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Customer WHERE Customer_id = '"+cidtext.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
            MessageBox.Show("Record Deleted Successfully");
            ResetRecords();
        }

        private void resetbutton_Click_1(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cidtext.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            cnametext.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            adrestext.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
