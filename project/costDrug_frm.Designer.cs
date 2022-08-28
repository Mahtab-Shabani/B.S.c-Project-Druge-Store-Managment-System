namespace project
{
    partial class costDrug_frm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_composer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idd = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(433, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "قیمت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(386, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "شرکت سازنده";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(250, 167);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_cost.Size = new System.Drawing.Size(117, 20);
            this.txt_cost.TabIndex = 3;
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress);
            // 
            // txt_composer
            // 
            this.txt_composer.Location = new System.Drawing.Point(250, 132);
            this.txt_composer.Name = "txt_composer";
            this.txt_composer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_composer.Size = new System.Drawing.Size(117, 20);
            this.txt_composer.TabIndex = 2;
            this.txt_composer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_composer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(448, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "نام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(430, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "شماره";
            // 
            // txt_idd
            // 
            this.txt_idd.Location = new System.Drawing.Point(250, 33);
            this.txt_idd.Name = "txt_idd";
            this.txt_idd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_idd.Size = new System.Drawing.Size(117, 20);
            this.txt_idd.TabIndex = 13;
            this.txt_idd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idd_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(250, 68);
            this.txt_name.Name = "txt_name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_name.Size = new System.Drawing.Size(117, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(31, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(445, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "نوع";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(250, 103);
            this.txt_type.Name = "txt_type";
            this.txt_type.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_type.Size = new System.Drawing.Size(117, 20);
            this.txt_type.TabIndex = 1;
            this.txt_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_type_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = global::project.Properties.Resources.gq_open_parent_folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(31, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "برگشت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Image = global::project.Properties.Resources.gq_cmd_edit_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(252, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_search.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(252, 202);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 38);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "جستجو";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.Image = global::project.Properties.Resources.gq_edit;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(384, 314);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 38);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "ویرایش";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.Image = global::project.Properties.Resources.gq_cmd_file_new;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(252, 314);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(89, 38);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "پاک کردن";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Image = global::project.Properties.Resources.gq_edit;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(384, 260);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 38);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "وارد کردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show.Image = global::project.Properties.Resources.folder_open;
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show.Location = new System.Drawing.Point(384, 202);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(89, 38);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "نمایش";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.untitled2;
            this.pictureBox1.Location = new System.Drawing.Point(31, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // help
            // 
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.help.Image = global::project.Properties.Resources.flpc_out_of_date;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(138, 314);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(89, 38);
            this.help.TabIndex = 4;
            this.help.Text = "راهنما";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
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
            // costDrug_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(518, 524);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_composer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idd);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "costDrug_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم قیمت داروها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_composer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idd;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشToolStripMenuItem;
    }
}