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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 아무거나_만들꺼
{
    public partial class Form2 : Form
    {
        string Conn = "Server=localhost;Database=gege;Uid=root;Pwd=dlalsrl2344@";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                conn.Open();
                MySqlCommand msc = new MySqlCommand("insert into ui(email, ID, PW) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "') ", conn);
                int a = msc.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("정상적으로 입력되었습니다");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Close();

        }
    }
}
