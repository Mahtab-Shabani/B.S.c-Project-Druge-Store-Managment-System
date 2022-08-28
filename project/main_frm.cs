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
    public partial class main_frm : Form
    {

        LoginClss lg = new LoginClss();

            int userlevel;
            int userid;

            public main_frm(int level,int id)
            {
                InitializeComponent();

                if (level==2)
                {
                    لوازمآرایشبهداشتیToolStripMenuItem.Visible = false;
                    افرادمتفرقهToolStripMenuItem1.Visible = false;
                    سطحدسترسیToolStripMenuItem.Visible = false;
                    پرسنلToolStripMenuItem1.Visible = false;
                    userlevel=level;
                    userid=id;
                }
                else if (level == 3)
                {
                    داروToolStripMenuItem1.Visible = false;
                    بیمارانToolStripMenuItem1.Visible = false;
                    سطحدسترسیToolStripMenuItem.Visible = false;
                    پرسنلToolStripMenuItem1.Visible = false;
                    userlevel = level;
                    userid = id;
                }
                
        }

        //********Declare Variable**********
        bool m = true;

        public main_frm()
        {
            InitializeComponent();
        }


        private void main_frm_Load(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //********فرم خروج***********
            exit_frm x = new exit_frm();
            x.Show();
        }

        private void بیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sick_frm s = new sick_frm();
            this.Hide();
            s.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
               if (label1.Left <= 900 && m == true)
               {
                   label1.Left += 10;
               }
               else
               {
                   m = false;
                   label1.Left -= 10;
                   if (label1.Left <= 20)
                       m = true;
               }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sick_frm s = new sick_frm();
            this.Hide();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drug_frm d = new drug_frm();
            this.Hide();
            d.ShowDialog(); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lavazem_frm l = new lavazem_frm();
            this.Hide();
            l.ShowDialog();
        }

        private void افرادمتفرقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body_frm b = new body_frm();
            this.Hide();
            b.ShowDialog();
        }

        private void بازکردنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sick_frm s = new sick_frm();
            this.Hide();
            s.ShowDialog();
        }

        private void بازکردنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            drug_frm d = new drug_frm();
            this.Hide();
            d.ShowDialog();
        }

        private void بازکردنToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            body_frm b = new body_frm();
            this.Hide();
            b.ShowDialog();
        }

        private void بازکردنToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lavazem_frm l = new lavazem_frm();
            this.Hide();
            l.ShowDialog();
        }

        private void فرملوازمآرایشیبهداشتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lavazem_frm l = new lavazem_frm();
            this.Hide();
            l.ShowDialog();
        }

        private void فروشلوازمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleLavazem_frm sl = new saleLavazem_frm();
            this.Hide();
            sl.ShowDialog();
        }

        private void فرمداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drug_frm d = new drug_frm();
            this.Hide();
            d.ShowDialog();
        }

        private void فروشداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleDrug_frm sd = new saleDrug_frm();
            this.Hide();
            sd.ShowDialog();
        }

        
        private void button6_Click_1(object sender, EventArgs e)
        {
            lavazem_frm l = new lavazem_frm();
            this.Hide();
            l.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saleLavazem_frm sl = new saleLavazem_frm();
            this.Hide();
            sl.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            body_frm b = new body_frm();
            this.Hide();
            b.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saleDrug_frm sd = new saleDrug_frm();
            this.Hide();
            sd.ShowDialog();
        }

        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای ثبت  کالا یا اشخاص نیازی به وارد کردن شماره نیست. شماره بصورت اتوماتیک وارد می شود", "راهنما", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void پرسنلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            personal_frm p = new personal_frm();
            p.Show();
        }

        private void بیمارانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sick_frm s = new sick_frm();
            s.Show();
        }

        private void افرادمتفرقهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            body_frm b = new body_frm();
            b.Show();
        }

        private void فرملوازمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lavazem_frm l = new lavazem_frm();
            l.Show();
        }

        private void فروشکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleLavazem_frm sl = new saleLavazem_frm();
            sl.Show();
        }

        private void لیستقیمتکالاهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costLavazem_frm cl = new costLavazem_frm();
            cl.Show();
        }

        private void فرمداروToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            drug_frm d = new drug_frm();
            d.Show();
        }

        private void فروشداروToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saleDrug_frm sd = new saleDrug_frm();
            sd.Show();
        }

        private void لیستقیمتداروهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costDrug_frm cd = new costDrug_frm();
            cd.Show();
        }

        

        private void سطحدسترسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            access_frm a = new access_frm();
            a.Show();
        }

        private void تغییررمزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeUser_frm cu = new changeUser_frm();
            cu.Show();
        }

        private void freecellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("freecell.exe");
        }

        private void heartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mshearts.exe");
        }

        private void spiderSolitareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("spider.exe");
        }

        private void minesweeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winmine.exe");
        }

        private void pinballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("pinball.exe");
        }

        private void solitaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("sol.exe");
        }      
        
    }
}