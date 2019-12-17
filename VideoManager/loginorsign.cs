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

namespace VideoManager
{
    public partial class loginorsign : Form
    {
        string loginsql = "select userid from appuser where username=@name and passwd=@pwd;";
        public loginorsign()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked && this.textBox1.Text!="")
            {
                SqlCommand mycom = new SqlCommand("username_not_repeat", MainWindow.mycon);

                mycom.CommandType = CommandType.StoredProcedure;
                SqlParameter username = new SqlParameter("@give_name", SqlDbType.VarChar,40);
                username.Value = this.textBox1.Text;
                mycom.Parameters.Add(username);

                SqlParameter usercount = new SqlParameter("@rt_isRep",SqlDbType.Int);
                mycom.Parameters.Add(usercount);
                usercount.Direction = ParameterDirection.Output;

                MainWindow.mycon.Open();
                {
                    mycom.BeginExecuteReader();
                }
                MainWindow.mycon.Close();
                if ((int)usercount.Value != 0)
                {
                    this.label3.Text = "已有此用户名x";
                    this.button1.Enabled = false;
                }
                else
                {
                    this.label3.Text = "用户名可用";
                    this.button1.Enabled = true;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.textBox1.ReadOnly = true;
                this.textBox2.ReadOnly = true;
                this.button1.Text = "游客登录";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.textBox1.ReadOnly = false;
                this.textBox2.ReadOnly = false;
                this.button1.Text = "登录";
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.textBox1.ReadOnly = false;
                this.textBox2.ReadOnly = false;
                this.button1.Text = "注册";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "")
            {
                if (this.textBox2.Text.Length < 8)
                {
                    this.label4.Text = "密码位数必须大于8位";
                    this.button1.Enabled = false;
                }
                else
                {
                    this.label4.Text = "密码正确";
                    this.button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((this.textBox1.Text !="") && (this.textBox2.Text != "") && (this.textBox1.Enabled && this.textBox2.Enabled))
            {
                SqlParameter name = new SqlParameter("@name", SqlDbType.VarChar, 40);
                SqlParameter pwd = new SqlParameter("@pwd", SqlDbType.Char, 32);
                if (this.radioButton1.Checked)
                {
                    SqlCommand mycom = new SqlCommand(loginsql, MainWindow.mycon);
                    mycom.Parameters.Add("@name",SqlDbType.VarChar,40)
                }
            }
        }
    }
}
