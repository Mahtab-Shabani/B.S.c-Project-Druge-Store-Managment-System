namespace project
{
    partial class lavazem_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lavazem_frm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darookhaneDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darookhaneDataSet1 = new project.darookhaneDataSet1();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_engheza = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_idd = new System.Windows.Forms.TextBox();
            this.txt_composer = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.analog1 = new Clock.Analog();
            this.help = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darookhaneDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darookhaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نمایشToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // نمایشToolStripMenuItem
            // 
            this.نمایشToolStripMenuItem.Name = "نمایشToolStripMenuItem";
            this.نمایشToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.نمایشToolStripMenuItem.Text = "نمایش";
            this.نمایشToolStripMenuItem.Click += new System.EventHandler(this.نمایشToolStripMenuItem_Click);
            // 
            // darookhaneDataSet1BindingSource
            // 
            this.darookhaneDataSet1BindingSource.DataSource = this.darookhaneDataSet1;
            this.darookhaneDataSet1BindingSource.Position = 0;
            // 
            // darookhaneDataSet1
            // 
            this.darookhaneDataSet1.DataSetName = "darookhaneDataSet1";
            this.darookhaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 519);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.Location = new System.Drawing.Point(355, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 237);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(868, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "قیمت";
            // 
            // dateTime_engheza
            // 
            this.dateTime_engheza.Location = new System.Drawing.Point(683, 231);
            this.dateTime_engheza.Name = "dateTime_engheza";
            this.dateTime_engheza.Size = new System.Drawing.Size(117, 20);
            this.dateTime_engheza.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1208, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "تعداد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(821, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "شرکت سازنده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(836, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "تاریخ انقضا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1221, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 54;
            this.label1.Text = "نام";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(683, 329);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_cost.Size = new System.Drawing.Size(117, 20);
            this.txt_cost.TabIndex = 4;
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1203, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "شماره";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(1023, 329);
            this.txt_number.Name = "txt_number";
            this.txt_number.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_number.Size = new System.Drawing.Size(117, 20);
            this.txt_number.TabIndex = 1;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress_1);
            // 
            // txt_idd
            // 
            this.txt_idd.Location = new System.Drawing.Point(1023, 228);
            this.txt_idd.Name = "txt_idd";
            this.txt_idd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_idd.Size = new System.Drawing.Size(117, 20);
            this.txt_idd.TabIndex = 14;
            this.txt_idd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idd_KeyPress_1);
            // 
            // txt_composer
            // 
            this.txt_composer.Location = new System.Drawing.Point(683, 281);
            this.txt_composer.Name = "txt_composer";
            this.txt_composer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_composer.Size = new System.Drawing.Size(117, 20);
            this.txt_composer.TabIndex = 3;
            this.txt_composer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_composer_KeyPress_1);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(1023, 278);
            this.txt_name.Name = "txt_name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_name.Size = new System.Drawing.Size(117, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::project.Properties.Resources.untitled101;
            this.pictureBox5.Location = new System.Drawing.Point(129, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(210, 82);
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::project.Properties.Resources.Recovered_Png_30;
            this.pictureBox4.Location = new System.Drawing.Point(47, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Image = global::project.Properties.Resources.gq_cmd_edit_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(709, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_search.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(594, 378);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 38);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "جستجو";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.Image = global::project.Properties.Resources.gq_edit;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(824, 378);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 38);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "ویرایش";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.Image = global::project.Properties.Resources.gq_cmd_file_new;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(475, 378);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 38);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "پاک کردن";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Image = global::project.Properties.Resources.gq_edit;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(939, 378);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(91, 38);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "وارد کردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click_1);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show.Image = global::project.Properties.Resources.folder_open;
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show.Location = new System.Drawing.Point(1049, 378);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(91, 38);
            this.btn_show.TabIndex = 6;
            this.btn_show.Text = "نمایش";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Image = global::project.Properties.Resources.gq_open_parent_folder;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(355, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "برگشت";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // analog1
            // 
            this.analog1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.analog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analog1.ClockText = "drugStore 2011";
            this.analog1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.analog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analog1.ForeColor = System.Drawing.Color.Black;
            this.analog1.FrameBackColor = System.Drawing.Color.WhiteSmoke;
            this.analog1.FrameForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.analog1.FrameMode = Clock.Analog.F_Mode.Circular;
            this.analog1.FrameStyle = System.Drawing.Drawing2D.HatchStyle.Plaid;
            this.analog1.FrameThickness = 8.5F;
            this.analog1.HourColor = System.Drawing.Color.Black;
            this.analog1.Location = new System.Drawing.Point(1087, 32);
            this.analog1.MinuteColor = System.Drawing.Color.Black;
            this.analog1.Name = "analog1";
            this.analog1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.analog1.SecondColor = System.Drawing.Color.Red;
            this.analog1.ShowDate = false;
            this.analog1.Size = new System.Drawing.Size(146, 146);
            this.analog1.TabIndex = 59;
            this.analog1.UseWaitCursor = true;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.WhiteSmoke;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.help.Image = global::project.Properties.Resources.flpc_out_of_date;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(1159, 378);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(94, 38);
            this.help.TabIndex = 5;
            this.help.Text = "راهنما";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // lavazem_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 701);
            this.Controls.Add(this.help);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.analog1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dateTime_engheza);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_idd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_composer);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.monthCalendar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lavazem_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوازم آرایشی/ بهداشتی";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.darookhaneDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darookhaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource darookhaneDataSet1BindingSource;
        private darookhaneDataSet1 darookhaneDataSet1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime_engheza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_idd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_composer;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button button2;
        private Clock.Analog analog1;
        private System.Windows.Forms.Button help;

    }
}