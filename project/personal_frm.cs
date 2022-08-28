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
    public partial class personal_frm : Form
    {

        //************ساختن شی از کلاس**********
        ClassPersonal cp = new ClassPersonal();

        public personal_frm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open file dialog 
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path
                txt_browser.Text = open.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main_frm m = new main_frm();
            //this.Hide();
            //m.ShowDialog();
            this.Close();
        }

        //********نمایش داده ها******************
        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cp.show();
            dataGridView1.DataSource = dt1;
        }

        private void personal_frm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //********وارد کردن داده ها*************
        private void btn_insert_Click(object sender, EventArgs e)
        {
            txt_pname.BackColor = Color.White;
            //txt_browser.BackColor = Color.White;
            //txt_fatherName.BackColor = Color.White;
            txt_reshteh.BackColor = Color.White;
            txt_tel.BackColor = Color.White;
            txt_idshenasname.BackColor = Color.White;
            txt_idMeli.BackColor = Color.White;
            cmb_degree.BackColor = Color.White;
            cmb_semat.BackColor = Color.White;
            if (cmb_semat.Text == "" || cmb_degree.Text == "" || txt_pname.Text == "" || txt_idMeli.Text == "" || txt_idshenasname.Text == "" || txt_family.Text == "" || txt_tel.Text == "")
            {
                if (txt_pname.Text == "")
                    txt_pname.BackColor = Color.Red;
                if (cmb_semat.Text == "")
                    cmb_semat.BackColor = Color.Red;
                if (txt_idMeli.Text == "")
                    txt_idMeli.BackColor = Color.Red;
                if (cmb_degree.Text == "")
                    cmb_degree.BackColor = Color.Red;
                if (txt_idshenasname.Text == "")
                    txt_idshenasname.BackColor = Color.Red;
                if (txt_family.Text == "")
                    txt_family.BackColor = Color.Red;
                if (txt_tel.Text == "")
                    txt_tel.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                cp.insert(txt_pname.Text, txt_family.Text, txt_fatherName.Text, int.Parse(txt_idshenasname.Text), int.Parse(txt_idMeli.Text), cmb_day.Text + "/" + cmb_month.Text + "/" + cmb_year.Text , txt_tel.Text, cmb_semat.Text, cmb_degree.Text, txt_reshteh.Text, txt_address.Text, pictureBox1.Image.ToString());
                btn_show_Click(null, null);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "شماره";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "نام پدر";
            dataGridView1.Columns[4].HeaderText = "شماره شناسنامه";
            dataGridView1.Columns[5].HeaderText = "کد ملی";
            dataGridView1.Columns[6].HeaderText = "تاریخ تولد";
            dataGridView1.Columns[7].HeaderText = "تلفن";
            dataGridView1.Columns[8].HeaderText = "سمت";
            dataGridView1.Columns[9].HeaderText = "میزان تحصیلات";
            dataGridView1.Columns[10].HeaderText = "رشته تحصیلی";
            dataGridView1.Columns[11].HeaderText = "آدرس";
            dataGridView1.Columns[12].HeaderText = "تصویر";

            int cr = dataGridView1.CurrentRow.Index;
            txt_id.Text = dataGridView1[0, cr].Value.ToString();
            txt_pname.Text = dataGridView1[1, cr].Value.ToString();
            txt_family.Text = dataGridView1[2, cr].Value.ToString();
            txt_fatherName.Text = dataGridView1[3, cr].Value.ToString();
            txt_idshenasname.Text = dataGridView1[4, cr].Value.ToString();
            txt_idMeli.Text = dataGridView1[5, cr].Value.ToString();
            //cmb_day.Text = dataGridView1[6, cr].Value.ToString();
            //cmb_month.Text = dataGridView1[6, cr].Value.ToString();
            cmb_year.Text = dataGridView1[6, cr].Value.ToString();
            txt_tel.Text = dataGridView1[7, cr].Value.ToString();
            cmb_semat.Text = dataGridView1[8, cr].Value.ToString();
            cmb_degree.Text = dataGridView1[9, cr].Value.ToString();
            txt_reshteh.Text = dataGridView1[10, cr].Value.ToString();
            txt_address.Text = dataGridView1[11, cr].Value.ToString();
            txt_browser.Text = dataGridView1[12, cr].Value.ToString();
        }

        //********ویرایش داده ها****************
        private void btn_update_Click(object sender, EventArgs e)
        {
            txt_pname.BackColor = Color.White;
            txt_reshteh.BackColor = Color.White;
            txt_tel.BackColor = Color.White;
            txt_idshenasname.BackColor = Color.White;
            txt_idMeli.BackColor = Color.White;
            cmb_degree.BackColor = Color.White;
            cmb_semat.BackColor = Color.White;
            if (cmb_semat.Text == "" || cmb_degree.Text == "" || txt_pname.Text == "" || txt_idMeli.Text == "" || txt_idshenasname.Text == "" || txt_family.Text == "" || txt_tel.Text == "")
            {
                if (txt_pname.Text == "")
                    txt_pname.BackColor = Color.Red;
                if (cmb_semat.Text == "")
                    cmb_semat.BackColor = Color.Red;
                if (txt_idMeli.Text == "")
                    txt_idMeli.BackColor = Color.Red;
                if (cmb_degree.Text == "")
                    cmb_degree.BackColor = Color.Red;
                if (txt_idshenasname.Text == "")
                    txt_idshenasname.BackColor = Color.Red;
                if (txt_family.Text == "")
                    txt_family.BackColor = Color.Red;
                if (txt_tel.Text == "")
                    txt_tel.BackColor = Color.Red;
                MessageBox.Show("لطفا فیلدها را پر نمایید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (txt_id.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                cp.update(txt_pname.Text, txt_family.Text, txt_fatherName.Text, int.Parse(txt_idshenasname.Text), int.Parse(txt_idMeli.Text), cmb_day.Text + "/" + cmb_month.Text + "/" + cmb_year.Text + "/", txt_tel.Text, cmb_semat.Text, cmb_degree.Text, txt_reshteh.Text, txt_address.Text, txt_browser.Text, int.Parse(txt_id.Text));
                btn_show_Click(null, null);
            }
        }

        //********حذف داده ها******************
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("لطفا شماره را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cp.delete(int.Parse(txt_id.Text));
                btn_show_Click(null, null);
            }

        }

        //********جستجوی داده******************
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_pname.Text == "" || txt_family.Text == "")
                MessageBox.Show("لطفا نام و نام خانوادگی فرد را بطور کامل وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable dt2 = cp.search(txt_pname.Text, txt_family.Text);
                dataGridView1.DataSource = dt2;
            }
        }

        //خالی کردن تکس باکس ها
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_pname.Text = "";
            txt_browser.Text = "";
            txt_fatherName.Text = "";
            txt_reshteh.Text = "";
            txt_tel.Text = "";
            txt_idshenasname.Text = "";
            txt_idMeli.Text = "";
            cmb_degree.Text = "";
            cmb_semat.Text = "";
            txt_family.Text = "";
            txt_address.Text = "";
            cmb_day.Text = "";
            cmb_month.Text = "";
            cmb_year.Text = "";
        }

        private void txt_pname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_family_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_fatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_reshteh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        private void txt_browser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_idshenasname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_idMeli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void cmb_semat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cmb_degree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cmb_day_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cmb_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void cmb_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ثبت پرسنل نیازی به وارد کردن شماره نیست. شماره بصورت اتوماتیک وارد می شود", "راهنما", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void مToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = cp.show();
            dataGridView1.DataSource = dt1;
        }

        
    }
}
