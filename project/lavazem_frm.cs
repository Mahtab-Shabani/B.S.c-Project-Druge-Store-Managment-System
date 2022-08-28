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
    public partial class lavazem_frm : Form
    {
        
        //************ساختن شی از کلاس**********
        ClassLavazem cl = new ClassLavazem();

        public lavazem_frm()
        {
            InitializeComponent();
        }

        private void wizardControl1_Load(object sender, EventArgs e)
        {

        }

        //********نمایش داده ها******************
        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cl.show();
            dataGridView1.DataSource = dt1;
        }

        //برگشت به فرم اصلی برنامه
        private void button1_Click(object sender, EventArgs e)
        {
            main_frm m = new main_frm();
            this.Hide();
            m.ShowDialog();
        }

        //********وارد کردن داده ها*************
        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_number.BackColor = Color.White;
            txt_cost.BackColor = Color.White;
            if ( txt_cost.Text == "" || txt_number.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                if (txt_number.Text == "")
                    txt_number.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cl.insert(txt_name.Text, int.Parse(txt_number.Text), dateTime_engheza.Value, txt_composer.Text, txt_cost.Text);
                btn_show_Click(null, null);
            }
        }

        //********ویرایش داده ها****************
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_cost.Text == "" || txt_number.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                if (txt_number.Text == "")
                    txt_number.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl.updatel(txt_name.Text, int.Parse(txt_number.Text), dateTime_engheza.Value, txt_composer.Text, txt_cost.Text, int.Parse(txt_idd.Text));
                btn_show_Click(null, null);

            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "تعداد";
            dataGridView1.Columns[5].HeaderText = "قیمت";
            dataGridView1.Columns[4].HeaderText = "شرکت سازنده";
            dataGridView1.Columns[3].HeaderText = "تاریخ";
            int cr = dataGridView1.CurrentRow.Index;
            txt_idd.Text = dataGridView1[0, cr].Value.ToString();
            txt_name.Text = dataGridView1[1, cr].Value.ToString();
            txt_number.Text = dataGridView1[2, cr].Value.ToString();
            txt_cost.Text = dataGridView1[5, cr].Value.ToString();
            txt_composer.Text = dataGridView1[4, cr].Value.ToString();
        }

        //********حذف داده ها******************
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl.delete(int.Parse(txt_idd.Text));
                btn_show_Click(null, null);
            }
        }

        //********جستجوی داده******************
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("لطفا نام لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt2 = cl.srch(txt_name.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        //راست کلیک برای نمایش داده ها
        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cl.show();
            dataGridView1.DataSource = dt1;
        }

        //خالی کردن تکس باکس ها
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_number.BackColor = Color.White;
            txt_cost.BackColor = Color.White;

            txt_idd.Text = "";
            txt_name.Text = "";
            txt_number.Text = "";
            txt_cost.Text = "";
            txt_composer.Text = "";
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_composer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    main_frm m = new main_frm();
        //    this.Hide();
        //    m.ShowDialog();
            this.Close();
        }

        private void btn_show_Click_1(object sender, EventArgs e)
        {
            DataTable dt1 = cl.show();
            dataGridView1.DataSource = dt1;
        }

        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_number.BackColor = Color.White;
            txt_cost.BackColor = Color.White;
            if (txt_cost.Text == "" || txt_number.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                if (txt_number.Text == "")
                    txt_number.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cl.insert(txt_name.Text, int.Parse(txt_number.Text), dateTime_engheza.Value, txt_composer.Text, txt_cost.Text);
                btn_show_Click(null, null);
            }
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (txt_cost.Text == "" || txt_number.Text == "" || txt_name.Text == "")
            {
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                if (txt_number.Text == "")
                    txt_number.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl.updatel(txt_name.Text, int.Parse(txt_number.Text), dateTime_engheza.Value, txt_composer.Text, txt_cost.Text, int.Parse(txt_idd.Text));
                btn_show_Click(null, null);

            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "تعداد";
            dataGridView1.Columns[5].HeaderText = "قیمت";
            dataGridView1.Columns[4].HeaderText = "شرکت سازنده";
            dataGridView1.Columns[3].HeaderText = "تاریخ";
            int cr = dataGridView1.CurrentRow.Index;
            txt_idd.Text = dataGridView1[0, cr].Value.ToString();
            txt_name.Text = dataGridView1[1, cr].Value.ToString();
            txt_number.Text = dataGridView1[2, cr].Value.ToString();
            txt_cost.Text = dataGridView1[5, cr].Value.ToString();
            txt_composer.Text = dataGridView1[4, cr].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl.delete(int.Parse(txt_idd.Text));
                btn_show_Click(null, null);
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("لطفا نام لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt2 = cl.srch(txt_name.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_idd.BackColor = Color.White;
            txt_name.BackColor = Color.White;
            txt_number.BackColor = Color.White;
            txt_cost.BackColor = Color.White;

            txt_idd.Text = "";
            txt_name.Text = "";
            txt_number.Text = "";
            txt_cost.Text = "";
            txt_composer.Text = "";
        }

        private void txt_idd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_number_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_cost_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_composer_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ثبت لوازم نیازی به وارد کردن شماره نیست. شماره بصورت اتوماتیک وارد می شود", "راهنما", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}