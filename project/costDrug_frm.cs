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
    public partial class costDrug_frm : Form
    {

        ClassCostDrug ccd = new ClassCostDrug();

        public costDrug_frm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نوع";
            dataGridView1.Columns[4].HeaderText = "قیمت";
            dataGridView1.Columns[3].HeaderText = "شرکت سازنده";

            int cr = dataGridView1.CurrentRow.Index;
            txt_idd.Text = dataGridView1[0, cr].Value.ToString();
            txt_name.Text = dataGridView1[1, cr].Value.ToString();
            txt_type.Text = dataGridView1[2, cr].Value.ToString();
            txt_cost.Text = dataGridView1[4, cr].Value.ToString();
            txt_composer.Text = dataGridView1[3, cr].Value.ToString();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = ccd.show();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_frm m = new main_frm();
            this.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_name.BackColor = Color.White;
            txt_type.BackColor = Color.White;
            txt_cost.BackColor = Color.White;
            if (txt_cost.Text == "" || txt_name.Text == "" || txt_type.Text=="")
            {
                if (txt_type.Text == "")
                    txt_type.BackColor = Color.Red;
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ccd.insert(txt_name.Text,txt_type.Text, txt_composer.Text, txt_cost.Text);
                btn_show_Click(null, null);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

             txt_name.BackColor = Color.White;
            txt_type.BackColor = Color.White;
            txt_cost.BackColor = Color.White;
            if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cost.Text == "" || txt_name.Text == "" || txt_type.Text == "")
            {
                if (txt_type.Text == "")
                    txt_type.BackColor = Color.Red;
                if (txt_name.Text == "")
                    txt_name.BackColor = Color.Red;
                if (txt_cost.Text == "")
                    txt_cost.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ccd.update(txt_name.Text, txt_type.Text, txt_composer.Text, txt_cost.Text, int.Parse(txt_idd.Text));
                btn_show_Click(null, null);
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_idd.Text == "")
            {
                MessageBox.Show("لطفا شماره ی لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ccd.delete(int.Parse(txt_idd.Text));
                btn_show_Click(null, null);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
                MessageBox.Show("لطفا نام لوازم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt2 = ccd.search(txt_name.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_idd.Text = "";
            txt_name.Text = "";
            txt_cost.Text = "";
            txt_composer.Text = "";
            txt_type.Text = "";
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_composer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_idd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ثبت لیست قیمت ها نیازی به وارد کردن شماره نیست. شماره بصورت اتوماتیک وارد می شود", "راهنما", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ccd.show();
            dataGridView1.DataSource = dt;
        }
    }
}
