using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Account
{
    public partial class Form3 : Form
    {
        MySqlConnection con1 = new MySqlConnection("server=localhost;user id=qtran;password=19031998;persistsecurityinfo=True;database=accountdatabase");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("insert into login(ID,UserName,Password)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", con1);
            con1.Open();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Save Success!");
            con1.Close();
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
