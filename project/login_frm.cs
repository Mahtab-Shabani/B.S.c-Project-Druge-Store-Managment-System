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
    public partial class login_frm : Form
    {
        private Point mouse_pos;
        private bool mouse_is_down = false; 
        //*******Declar Variable********
        public static int id = 0;
        public static int userlevel = 0;
        LoginClss lg = new LoginClss();

        public login_frm()
        {
            InitializeComponent();
        }
        
        private void txt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable dtLogin = lg.LoginData(txt_us.Text.Trim(), txt_pass.Text.Trim());

            //txt_us.BackColor = Color.White;
            //txt_pass.BackColor = Color.White;
            //if (txt_us.Text == "" || txt_pass.Text == "")
            //{
            //    if (txt_us.Text == "" && txt_pass.Text == "")
            //    {
            //        MessageBox.Show("لطفا کلمه عبور و رمز عبور را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_us.BackColor = Color.Red;
            //        txt_pass.BackColor = Color.Red;
            //        txt_us.Focus();
            //    }
            //    else if (txt_us.Text == "")
            //    {
            //        MessageBox.Show("لطفا کلمه عبور را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_us.BackColor = Color.Red;
            //        txt_us.Focus();
            //    }
            //    else if (txt_pass.Text == "")
            //    {
            //        MessageBox.Show("لطفا رمز عبور را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_pass.BackColor = Color.Red;
            //        txt_pass.Focus();
            //    }
            //}

            //else
            //{
                if (dtLogin.Rows.Count != 0)
                {
                    userlevel = int.Parse(dtLogin.Rows[0]["userLevel"].ToString());
                    id = int.Parse(dtLogin.Rows[0]["userCode"].ToString());

                    main_frm m = new main_frm(userlevel,id);

                    //LoginClss lg = new LoginClss();
                    //int userlevel= lg.GetUserLevel(txt_us.Text.Trim(), txt_pass.Text.Trim());
                    this.Hide();
                    m.ShowDialog();
                }
                //if ((txt_us.Text == "dr" && txt_pass.Text == "admin12") || (txt_us.Text == "accept1" && txt_pass.Text == "ill1") || (txt_us.Text == "accept2" && txt_pass.Text == "odd2"))
                //{
                //}

                else
                {
                    MessageBox.Show("کلمه عبور یا رمز عبور اشتباه است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_us.BackColor = Color.Red;
                    txt_pass.BackColor = Color.Red;
                    txt_us.Text = string.Empty;
                    txt_pass.Text = string.Empty;
                    txt_us.Focus();
                }
            //}
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            
        }

        private void login_frm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_pos.X = e.X;
            mouse_pos.Y = e.Y;
            mouse_is_down = true; 
        }

        private void login_frm_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_is_down = false;
        }

        private void login_frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_is_down)
            {
                Point current_pos = Control.MousePosition;
                current_pos.X = current_pos.X - mouse_pos.X; //add this current_pos.Y = current_pos.Y - mouse_pos.Y; //add this
                current_pos.Y = current_pos.Y - mouse_pos.Y;
                this.Location = current_pos;
            }
        }


    }
}
