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
    public partial class access_frm : Form
    {
        //*******************************
        ClassAccessLevel cal = new ClassAccessLevel();
        ClassPersonal cp = new ClassPersonal();
        
        public access_frm()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای تعیین سطح دسترسی ابتدا شناسه فرد مورد نظر را از صفحه پرسنل بدست آورید.نیازی به وارد کردن شماره نیست","راهنما",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personal_frm p = new personal_frm();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_frm m = new main_frm(0,0);
            this.Close();
        }

        //********نمایش داده ها******************
        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = cal.show();
            dataGridView1.DataSource = dt;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_perId.BackColor = Color.White;
            txt_pass.BackColor = Color.White;
            txt_name.BackColor = Color.White;

            if (txt_name.Text.Trim() == "" || txt_pass.Text.Trim() == "" || txt_perId.Text.Trim() == "")
            {
                if (txt_name.Text == "")
                { txt_name.BackColor = Color.Red; }
                if (txt_pass.Text == "")
                { txt_pass.BackColor = Color.Red; }
                if (txt_perId.Text == "")
                { txt_perId.BackColor = Color.Red; }
                MessageBox.Show("لطفا فیلدهای قرمز را پرکنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dtsrch = cal.searchByUseCode(int.Parse(txt_perId.Text.Trim()));
                if (dtsrch.Rows.Count != 0)
                {

                    MessageBox.Show("سطح دسترسی این کارمند تعیین شده  ","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_name.Text = "";
                    txt_pass.Text = "";
                    txt_perId.Text = "";
                    rBtn_one.Checked = true;
                }
                else
                {
                    DataTable dtsrch1 = cp.searchById(int.Parse(txt_perId.Text.Trim())); 
                    if (dtsrch1.Rows.Count != 0)
                    {
                        txt_name.BackColor = Color.White;
                        txt_pass.BackColor = Color.White;
                        txt_perId.BackColor = Color.White;
                        if (txt_name.Text == "" || txt_pass.Text == "" || txt_perId.Text == "")
                        {
                            if (txt_name.Text == "")
                            { txt_name.BackColor = Color.Red; }

                            if (txt_pass.Text == "")
                            { txt_pass.BackColor = Color.Red; }

                            if (txt_perId.Text == "")
                            { txt_perId.BackColor = Color.Red; }
                            MessageBox.Show("لطفا فیلدهای قرمز را پرکنید", "پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }

                        else
                        {
                            string level = "";
                            {
                                if (rBtn_one.Checked)
                                { level = "1"; }
                                else if (rBtn_two.Checked)
                                { level = "2"; }
                                else if (rBtn_three.Checked)
                                { level = "3"; }

                            }
                            int lvl = int.Parse(level.ToString());
                            cal.insert(txt_name.Text.Trim(), txt_pass.Text.Trim(), lvl, int.Parse(txt_perId.Text.Trim()));
                            cal.show();
                            DataTable dt = cal.show();
                            dataGridView1.DataSource = dt;

                            MessageBox.Show("ثبت شد", "پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            txt_name.Text = "";
                            txt_pass.Text = "";
                            txt_perId.Text = "";
                            rBtn_one.Checked = true;

                        }
                    }
                    else
                    {
                        MessageBox.Show("کارمندی با این شماره پرسنلی موجود نیست","پیغام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txt_name.Text = "";
                        txt_pass.Text = "";
                        txt_perId.Text = "";
                        rBtn_one.Checked = true;
                    }
                }
            }
        }
            

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_idd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }             

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                cal.del(int.Parse(txt_id.Text));
                btn_show_Click(null, null);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "رمز عبور";
            dataGridView1.Columns[3].HeaderText = "سطح دسترسی";
            dataGridView1.Columns[4].HeaderText = "شماره پرسنلی";
           
            int cr = dataGridView1.CurrentRow.Index;
            txt_id.Text = dataGridView1[0, cr].Value.ToString();
            txt_name.Text = dataGridView1[1, cr].Value.ToString();
            txt_pass.Text = dataGridView1[2, cr].Value.ToString();
            txt_perId.Text = dataGridView1[3, cr].Value.ToString();
        }

        private void btn_srchbyperId_Click(object sender, EventArgs e)
        {
            if (txt_perId.Text == "")
            {
                MessageBox.Show("لطفا شماره پرسنلی را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt2 = cal.searchByUseCode(int.Parse(txt_perId.Text));
                dataGridView1.DataSource = dt2;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" && txt_pass.Text=="")
            {
                MessageBox.Show("لطفا نام و پسورد را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt1 = cal.search(txt_name.Text, txt_pass.Text);
                dataGridView1.DataSource = dt1;
            }
        }

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cal.show();
            dataGridView1.DataSource = dt1;
        }

    }
}
