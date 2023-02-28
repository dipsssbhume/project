using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            button3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string User, Pass;

            User = txtUser.Text;
            Pass = txtPass.Text;
            textBox1.Visible = false;
            button3.Visible = false;
            if (User=="admin"&& Pass=="admin")

            {
               
                MessageBox.Show("Successful Login..");
                button3.Visible = true;
                textBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox1.Visible = false;

            }

            else
            {
                MessageBox.Show("Incorrect Username or Password..");
                button3.Visible = false;
                textBox1.Visible = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            }

        private void button3_Click(object sender, EventArgs e)
            
        {
            
            int n, result, tm;
            string str;
            tm = int.Parse(textBox1.Text);
            this.textBox3.Text = "";
            for (n = 1; n<=10;n++)
            {
                str = tm + "x" + n + "=";
                result = tm * n;
                this.textBox3.Text = textBox3.Text + str + result + "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filepath = filepath + (@"\Log File"+" "+ DateTime.Now.ToString("dd-mm-yyyy hh-mm-ss")+".txt");

            TextWriter writer = new StreamWriter(filepath);
            string data1 = textBox3.Text;
            writer.WriteLine(data1);
            writer.Close();
            
            
            MessageBox.Show("Successfully Text File Created...");
        }

       
        }
    }
    
    

