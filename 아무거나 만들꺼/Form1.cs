using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 아무거나_만들꺼
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "minki05622" && textBox2.Text == "dlalsrl2344@")
            {
                MessageBox.Show("로그인 성공","로그인", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else 
            {
                MessageBox.Show("로그인 실패", "꺼져", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
          
            

        }
    }
}
