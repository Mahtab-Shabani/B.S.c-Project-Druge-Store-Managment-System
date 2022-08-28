using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class changeUser_frm : Form
    {

        //******************
        ClassAccessLevel cal = new ClassAccessLevel();

        public changeUser_frm()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            txt_name.BackColor = Color.White;
            txt_passOld.BackColor = Color.White;
            txt_newpass.BackColor = Color.White;
            txt_repeatPass.BackColor = Color.White;

            if (txt_name.Text == "" || txt_passOld.Text == "" ||txt_repeatPass.Text==""||txt_newpass.Text=="")
            {
                if (txt_name.Text == "")
                { txt_name.BackColor = Color.Red; }

                if (txt_passOld.Text == "")
                { txt_passOld.BackColor = Color.Red; }

                if (txt_newpass.Text == "")
                { txt_newpass.BackColor = Color.Red; }

                if (txt_repeatPass.Text == "")
                { txt_repeatPass.BackColor = Color.Red; }
                MessageBox.Show("لطفا فیلدهای قرمز را پرکنید","پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                 DataTable dtSearch = cal.search(txt_name.Text,txt_passOld.Text.Trim());
                 if (dtSearch.Rows.Count != 0)
                 {
                     if (txt_repeatPass.Text == txt_newpass.Text)
                     {
                         DataTable dtSearch1 = cal.search(txt_name.Text, txt_newpass.Text.Trim());
                         if (dtSearch1.Rows.Count != 0)
                         { MessageBox.Show("رمزعبور نامعتبر است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                         txt_newpass.Text = "";
                         txt_repeatPass.Text = "";
                         }
                         else
                         {
                             cal.update1(txt_name.Text,txt_passOld.Text,txt_newpass.Text);
                             MessageBox.Show("نام کاربری:" + txt_name.Text + "\n" + "رمز جدید:" + txt_newpass.Text,"پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                             txt_passOld.Text = "";
                             txt_name.Text = "";
                             txt_newpass.Text = "";
                             txt_repeatPass.Text = "";
                         }
                     }
                     else
                     {
                         MessageBox.Show("رمز عبور هماهنگ نیست", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                         txt_newpass.Text = "";
                         txt_repeatPass.Text = "";
                     }                    
                  
                 }                     
                 else
                 {
                     MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                     txt_passOld.Text ="";
                     txt_name.Text ="";
                     txt_newpass.Text = "";
                     txt_repeatPass.Text = "";
                 }                 
                
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
