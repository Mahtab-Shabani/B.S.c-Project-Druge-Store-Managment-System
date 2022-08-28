namespace project
{
    partial class access_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_perId = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rBtn_one = new System.Windows.Forms.RadioButton();
            this.rBtn_two = new System.Windows.Forms.RadioButton();
            this.rBtn_three = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_srchbyperId = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(216, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "شماره پرسنلی";
            // 
            // txt_perId
            // 
            this.txt_perId.AccessibleDescription = "ser";
            this.txt_perId.Location = new System.Drawing.Point(56, 50);
            this.txt_perId.Name = "txt_perId";
            this.txt_perId.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_perId.Size = new System.Drawing.Size(127, 20);
            this.txt_perId.TabIndex = 0;
            this.txt_perId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idd_KeyPress);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(57, 121);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_pass.Size = new System.Drawing.Size(126, 20);
            this.txt_pass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(249, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "رمز عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(250, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "نام کاربر";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(56, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_name.Size = new System.Drawing.Size(127, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(213, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "سطح دسترسی";
            // 
            // rBtn_one
            // 
            this.rBtn_one.AutoSize = true;
            this.rBtn_one.Location = new System.Drawing.Point(152, 170);
            this.rBtn_one.Name = "rBtn_one";
            this.rBtn_one.Size = new System.Drawing.Size(31, 17);
            this.rBtn_one.TabIndex = 3;
            this.rBtn_one.TabStop = true;
            this.rBtn_one.Text = "1";
            this.rBtn_one.UseVisualStyleBackColor = true;
            // 
            // rBtn_two
            // 
            this.rBtn_two.AutoSize = true;
            this.rBtn_two.Location = new System.Drawing.Point(120, 170);
            this.rBtn_two.Name = "rBtn_two";
            this.rBtn_two.Size = new System.Drawing.Size(31, 17);
            this.rBtn_two.TabIndex = 4;
            this.rBtn_two.TabStop = true;
            this.rBtn_two.Text = "2";
            this.rBtn_two.UseVisualStyleBackColor = true;
            // 
            // rBtn_three
            // 
            this.rBtn_three.AutoSize = true;
            this.rBtn_three.Location = new System.Drawing.Point(84, 170);
            this.rBtn_three.Name = "rBtn_three";
            this.rBtn_three.Size = new System.Drawing.Size(31, 17);
            this.rBtn_three.TabIndex = 5;
            this.rBtn_three.TabStop = true;
            this.rBtn_three.Text = "3";
            this.rBtn_three.UseVisualStyleBackColor = true;
            this.rBtn_three.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.rBtn_three);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rBtn_two);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rBtn_one);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_perId);
            this.panel1.Location = new System.Drawing.Point(405, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 202);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(262, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "شماره";
            // 
            // txt_id
            // 
            this.txt_id.AccessibleDescription = "ser";
            this.txt_id.Location = new System.Drawing.Point(57, 14);
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_id.Size = new System.Drawing.Size(127, 20);
            this.txt_id.TabIndex = 6;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idd_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(86, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 95);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.Location = new System.Drawing.Point(657, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "صفحه پرسنل";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // help
            // 
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.help.Image = global::project.Properties.Resources.flpc_out_of_date;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(665, 347);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(89, 37);
            this.help.TabIndex = 1;
            this.help.Text = "راهنما";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = global::project.Properties.Resources.gq_open_parent_folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(657, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "برگشت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Image = global::project.Properties.Resources.gq_cmd_edit_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(357, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_search.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(86, 347);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 37);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "جستجو";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_srchbyperId
            // 
            this.btn_srchbyperId.BackColor = System.Drawing.Color.White;
            this.btn_srchbyperId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_srchbyperId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_srchbyperId.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_srchbyperId.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_srchbyperId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_srchbyperId.Location = new System.Drawing.Point(192, 347);
            this.btn_srchbyperId.Name = "btn_srchbyperId";
            this.btn_srchbyperId.Size = new System.Drawing.Size(150, 37);
            this.btn_srchbyperId.TabIndex = 5;
            this.btn_srchbyperId.Text = "جستجو با ش پرسنلی";
            this.btn_srchbyperId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_srchbyperId.UseVisualStyleBackColor = false;
            this.btn_srchbyperId.Click += new System.EventHandler(this.btn_srchbyperId_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Image = global::project.Properties.Resources.gq_edit;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(461, 347);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 37);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "وارد کردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show.Image = global::project.Properties.Resources.folder_open;
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show.Location = new System.Drawing.Point(562, 347);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(89, 37);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "نمایش";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox3.Image = global::project.Properties.Resources.Recovered_Png_27;
            this.pictureBox3.Location = new System.Drawing.Point(405, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.untitled11;
            this.pictureBox2.Location = new System.Drawing.Point(524, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::project.Properties.Resources.Recovered_Png_42;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نمایشToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // نمایشToolStripMenuItem
            // 
            this.نمایشToolStripMenuItem.Name = "نمایشToolStripMenuItem";
            this.نمایشToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.نمایشToolStripMenuItem.Text = "نمایش";
            this.نمایشToolStripMenuItem.Click += new System.EventHandler(this.نمایشToolStripMenuItem_Click);
            // 
            // access_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 517);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.help);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_srchbyperId);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "access_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سطح دسترسی";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_perId;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtn_one;
        private System.Windows.Forms.RadioButton rBtn_two;
        private System.Windows.Forms.RadioButton rBtn_three;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_srchbyperId;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشToolStripMenuItem;
    }
}