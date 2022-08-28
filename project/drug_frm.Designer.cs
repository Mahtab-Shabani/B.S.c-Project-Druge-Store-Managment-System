namespace project
{
    partial class drug_frm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTime_engheza = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idd = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_composer = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.dateTime_tolid = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.analog1 = new Clock.Analog();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = global::project.Properties.Resources.gq_open_parent_folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(368, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "برگشت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Image = global::project.Properties.Resources.gq_cmd_edit_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(714, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_search.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(596, 354);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 41);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "جستجو";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.Image = global::project.Properties.Resources.gq_edit;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(832, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 41);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "ویرایش";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.Image = global::project.Properties.Resources.gq_cmd_file_new;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(483, 354);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 41);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "پاک کردن";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Image = global::project.Properties.Resources.gq_edit;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(943, 354);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(90, 41);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "وارد کردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show.Image = global::project.Properties.Resources.folder_open;
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show.Location = new System.Drawing.Point(1058, 354);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(82, 41);
            this.btn_show.TabIndex = 9;
            this.btn_show.Text = "نمایش";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(368, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 277);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // dateTime_engheza
            // 
            this.dateTime_engheza.Location = new System.Drawing.Point(1011, 298);
            this.dateTime_engheza.Name = "dateTime_engheza";
            this.dateTime_engheza.Size = new System.Drawing.Size(140, 20);
            this.dateTime_engheza.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(878, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "وزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(822, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "شرکت سازنده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1179, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "تاریخ انقضا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(871, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "تعداد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1224, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "نام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1206, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 39;
            this.label5.Text = "شماره";
            // 
            // txt_idd
            // 
            this.txt_idd.Location = new System.Drawing.Point(1011, 74);
            this.txt_idd.Name = "txt_idd";
            this.txt_idd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_idd.Size = new System.Drawing.Size(140, 20);
            this.txt_idd.TabIndex = 19;
            this.txt_idd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idd_KeyPress);
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(639, 298);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_cost.Size = new System.Drawing.Size(140, 20);
            this.txt_cost.TabIndex = 7;
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(639, 189);
            this.txt_number.Name = "txt_number";
            this.txt_number.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_number.Size = new System.Drawing.Size(140, 20);
            this.txt_number.TabIndex = 5;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_composer
            // 
            this.txt_composer.Location = new System.Drawing.Point(639, 243);
            this.txt_composer.Name = "txt_composer";
            this.txt_composer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_composer.Size = new System.Drawing.Size(140, 20);
            this.txt_composer.TabIndex = 6;
            this.txt_composer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_composer_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(1011, 136);
            this.txt_name.Name = "txt_name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_name.Size = new System.Drawing.Size(140, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(1011, 189);
            this.txt_type.Name = "txt_type";
            this.txt_type.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_type.Size = new System.Drawing.Size(140, 20);
            this.txt_type.TabIndex = 1;
            this.txt_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_type_KeyPress);
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(639, 136);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_weight.Size = new System.Drawing.Size(140, 20);
            this.txt_weight.TabIndex = 4;
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            // 
            // dateTime_tolid
            // 
            this.dateTime_tolid.Location = new System.Drawing.Point(1011, 242);
            this.dateTime_tolid.Name = "dateTime_tolid";
            this.dateTime_tolid.Size = new System.Drawing.Size(140, 20);
            this.dateTime_tolid.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(1221, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "نوع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(1178, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "تاریخ تولید";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(869, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "قیمت";
            // 
            // analog1
            // 
            this.analog1.BackColor = System.Drawing.SystemColors.Window;
            this.analog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analog1.ClockText = "DrugStore 2011";
            this.analog1.DigitalClock = false;
            this.analog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analog1.FrameBackColor = System.Drawing.Color.WhiteSmoke;
            this.analog1.FrameForeColor = System.Drawing.Color.White;
            this.analog1.FrameMode = Clock.Analog.F_Mode.Circular;
            this.analog1.FrameStyle = System.Drawing.Drawing2D.HatchStyle.SolidDiamond;
            this.analog1.FrameThickness = 9F;
            this.analog1.HourColor = System.Drawing.Color.Black;
            this.analog1.Location = new System.Drawing.Point(368, 42);
            this.analog1.MinuteColor = System.Drawing.Color.Black;
            this.analog1.Name = "analog1";
            this.analog1.SecondColor = System.Drawing.Color.Red;
            this.analog1.ShowDate = false;
            this.analog1.Size = new System.Drawing.Size(157, 157);
            this.analog1.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::project.Properties.Resources.untitled101;
            this.pictureBox5.Location = new System.Drawing.Point(125, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(210, 82);
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::project.Properties.Resources.Recovered_Png_30;
            this.pictureBox4.Location = new System.Drawing.Point(44, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 527);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.WhiteSmoke;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.help.Image = global::project.Properties.Resources.flpc_out_of_date;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(1164, 354);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(89, 41);
            this.help.TabIndex = 8;
            this.help.Text = "راهنما";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // drug_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1262, 701);
            this.Controls.Add(this.help);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.analog1);
            this.Controls.Add(this.dateTime_tolid);
            this.Controls.Add(this.dateTime_engheza);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idd);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_composer);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "drug_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم دارو";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTime_engheza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idd;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_composer;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.DateTimePicker dateTime_tolid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نمایشToolStripMenuItem;
        private Clock.Analog analog1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button help;
    }
}