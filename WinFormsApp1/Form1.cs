using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string[,] usersLogin;

        public Form1()
        {
            InitializeComponent();
            usersLogin = new string[5, 2]
            {
                {"user1", "pas1"},
                {"user2", "pas2"},
                {"user3", "pas3"},
                {"user4", "pas4"},
                {"user5", "pas5"}
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = usersLogin.GetUpperBound(0) + 1;
            int colums = usersLogin.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (usersLogin[i, 0] == textBox1.Text.ToLower() && usersLogin[i, j] == textBox1.Text) 
                    {
                        MessageBox.Show("Access Login\n\nHello " + usersLogin[i, 0]);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Access is denied");
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
