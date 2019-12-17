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
using System.Security.Cryptography;

namespace VideoManager
{
    public partial class loginorsign : Form
    {
        string loginsql = "select userid,username,avator,claims,loginnum from appuser where username=@name and passwd=@pwd;";
        string signupsql = "insert into appuser (username,passwd,claims,loginnum) values(@name,@pwd,'user',0)";
        public loginorsign()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked && this.textBox1.Text!="")
            {
                SqlCommand mycom = new SqlCommand("username_not_repeat", MainWindow.mycon);

                mycom.CommandType = CommandType.StoredProcedure;
                SqlParameter username = new SqlParameter("@give_name", SqlDbType.VarChar,40);
                username.Value = this.textBox1.Text;
                mycom.Parameters.Add(username);

                SqlParameter usercount = new SqlParameter("@rt_isRep",SqlDbType.Int);
                usercount.Direction = ParameterDirection.Output;
                mycom.Parameters.Add(usercount);
                

                MainWindow.mycon.Open();
                {
                    mycom.ExecuteNonQuery();
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
            if(this.radioButton3.Checked && this.textBox1.Text != "")
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


        public static string GetMd5Hash(String input)
        {
            if (input == null)
            {
                return null;
            }

            MD5 md5Hash = MD5.Create();

            // 将输入字符串转换为字节数组并计算哈希数据
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // 创建一个 Stringbuilder 来收集字节并创建字符串
            StringBuilder sBuilder = new StringBuilder();

            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // 返回十六进制字符串
            return sBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter name = new SqlParameter("@name", SqlDbType.VarChar, 40);
            SqlParameter pwd = new SqlParameter("@pwd", SqlDbType.Char, 32);
            if ((this.textBox1.Text !="") && (this.textBox2.Text != ""))
            {
                name.Value = this.textBox1.Text.Trim();
                pwd.Value = GetMd5Hash(this.textBox2.Text.Trim());
                if (this.radioButton1.Checked)
                {
                    SqlCommand mycom = new SqlCommand(loginsql, MainWindow.mycon);
                    mycom.Parameters.Add(name);
                    mycom.Parameters.Add(pwd);
                    try 
                    {
                        MainWindow.mycon.Open();
                        {
                            SqlDataReader myReader = mycom.ExecuteReader();
                            while (myReader.Read())//判断是否有数据
                            {
                                if (myReader["username"].ToString() == this.textBox1.Text)
                                {
                                    MainWindow.myaccount.username = myReader["username"].ToString();
                                    MainWindow.myaccount.isLogin = true;
                                    MainWindow.myaccount.userid = (int)myReader["userid"];
                                    if (myReader["claims"].ToString() == "admin")
                                        MainWindow.myaccount.claim = claims.admin;
                                    else
                                        MainWindow.myaccount.claim = claims.user;
                                    if (myReader["avator"].GetType() != typeof(System.DBNull))
                                        MainWindow.myaccount.avater = (Byte[])myReader["avator"];
                                    SqlCommand mycommnum = new SqlCommand("update appuser set loginnum = "+ ((int)(myReader["loginnum"])+1).ToString()+";", MainWindow.mycon);
                                    MainWindow.mycon.Close();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                        MainWindow.mycon.Close();
                        MessageBox.Show("用户名或密码错误");
                        return;
                    }
                    catch (Exception ex)
                    {
                        MainWindow.mycon.Close();
                        MessageBox.Show("error" + ex.ToString()) ;
                        return;
                    }
                    
                }
                else if (this.radioButton3.Checked)
                {
                    SqlCommand mycom = new SqlCommand(signupsql, MainWindow.mycon);
                    mycom.Parameters.Add(name);
                    mycom.Parameters.Add(pwd);
                    try
                    {
                        MainWindow.mycon.Open();
                        {
                            mycom.ExecuteNonQuery();
                        }
                        MainWindow.mycon.Close();
                        MessageBox.Show("注册成功");
                        this.radioButton1.Checked = true;
                        return;
                    }
                    catch
                    {
                        MainWindow.mycon.Close();
                        MessageBox.Show("注册失败");
                        return;
                    }

                }
            }
            else if(this.radioButton2.Checked == true)
            {
                MainWindow.myaccount.username = "guest";
                MainWindow.myaccount.isLogin = true;
                MainWindow.myaccount.userid = 0;
                MainWindow.myaccount.claim = claims.guest;
                //MainWindow.myaccount.avater = ;

                MessageBox.Show("作为游客登录");
                this.Close();
                return;
            }
        }
    }
}
