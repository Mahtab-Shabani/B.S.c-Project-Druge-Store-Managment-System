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
    public partial class body_frm : Form
    {
        //************ساختن شی از کلاس**********
        ClassBody cb = new ClassBody();

        public body_frm()
        {
            InitializeComponent();
        }

        //برگشت به فرم اصلی برنامه
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        //********نمایش داده ها******************
        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cb.show();
            dataGridView1.DataSource = dt1;
        }

        //********وارد کردن داده ها*************
        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_age.BackColor = Color.White;
            cmb_gender.BackColor = Color.White;

            if (cmb_gender.Text == "" || txt_age.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (cmb_gender.Text == "")
                    cmb_gender.BackColor = Color.Red;
                if (txt_age.Text == "")
                    txt_age.BackColor = Color.Red;
                MessageBox.Show("لطفا همه فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (int.Parse(txt_age.Text) >= 100)
            {
                MessageBox.Show("سن بالاتر از حد مجاز است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_age.Text = "";
                txt_age.Focus();
            }

            else
            {
                cb.insert(txt_name.Text, int.Parse(txt_age.Text), cmb_gender.Text);
                btn_show_Click(null, null);
            }

        }

        //********ویرایش داده ها****************
        private void btn_update_Click(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_age.BackColor = Color.White;
            cmb_gender.BackColor = Color.White;

            if (int.Parse(txt_age.Text) >= 100)
            {
                MessageBox.Show("سن بالاتر از حد مجاز است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_age.Text = "";
                txt_age.Focus();
            }

            else if (cmb_gender.Text == "" || txt_age.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (cmb_gender.Text == "")
                    cmb_gender.BackColor = Color.Red;
                if (txt_age.Text == "")
                    txt_age.BackColor = Color.Red;
                MessageBox.Show("لطفا همه فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txt_idd.Text == "")
            {
                MessageBox.Show("شماره را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                cb.update(txt_name.Text, int.Parse(txt_age.Text), cmb_gender.Text, int.Parse(txt_idd.Text));
                btn_show_Click(null, null);
            }
            
        }

        //********حذف داده ها******************
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txt_idd.Text);
                cb.delete(id);

                btn_show_Click(null, null);
            }
        }

        //********جستجوی داده******************
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("لطفا نام فرد را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt2 = cb.search(txt_name.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        //خالی کردن تکس باکس ها
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_idd.Text = "";
            txt_name.Text = "";
            txt_age.Text = "";
            cmb_gender.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "سن";
            dataGridView1.Columns[3].HeaderText = "جنسیت";
            int cr = dataGridView1.CurrentRow.Index;
            txt_idd.Text = dataGridView1[0, cr].Value.ToString();
            txt_name.Text = dataGridView1[1, cr].Value.ToString();
            txt_age.Text = dataGridView1[2, cr].Value.ToString();
            cmb_gender.Text = dataGridView1[3, cr].Value.ToString();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void cmb_gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void body_frm_Load(object sender, EventArgs e)
        {

        }

        //راست کلیک برای نمایش داده ها
        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cb.show();
            dataGridView1.DataSource = dt1;
        }

        private void txt_idd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ثبت اشخاص نیازی به وارد کردن شماره نیست. شماره بصورت اتوماتیک وارد می شود","راهنما",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
