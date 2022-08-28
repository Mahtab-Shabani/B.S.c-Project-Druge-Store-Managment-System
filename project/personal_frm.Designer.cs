namespace project
{
    partial class personal_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idshenasname = new System.Windows.Forms.TextBox();
            this.txt_family = new System.Windows.Forms.TextBox();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idMeli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_day = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.txt_reshteh = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fatherName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_pic = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_browser = new System.Windows.Forms.TextBox();
            this.cmb_semat = new System.Windows.Forms.ComboBox();
            this.cmb_degree = new System.Windows.Forms.ComboBox();
            this.help = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.مToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(1016, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "شماره پرسنلی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1080, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "نام";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1026, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "نام خانوادگی";
            // 
            // txt_idshenasname
            // 
            this.txt_idshenasname.Location = new System.Drawing.Point(871, 204);
            this.txt_idshenasname.Name = "txt_idshenasname";
            this.txt_idshenasname.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_idshenasname.Size = new System.Drawing.Size(122, 20);
            this.txt_idshenasname.TabIndex = 3;
            this.txt_idshenasname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idshenasname_KeyPress);
            // 
            // txt_family
            // 
            this.txt_family.Location = new System.Drawing.Point(871, 120);
            this.txt_family.Name = "txt_family";
            this.txt_family.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_family.Size = new System.Drawing.Size(122, 20);
            this.txt_family.TabIndex = 1;
            this.txt_family.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_family_KeyPress);
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(871, 79);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_pname.Size = new System.Drawing.Size(122, 20);
            this.txt_pname.TabIndex = 0;
            this.txt_pname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1003, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "شماره شناسنامه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(1056, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "کد ملی";
            // 
            // txt_idMeli
            // 
            this.txt_idMeli.Location = new System.Drawing.Point(871, 247);
            this.txt_idMeli.Name = "txt_idMeli";
            this.txt_idMeli.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_idMeli.Size = new System.Drawing.Size(122, 20);
            this.txt_idMeli.TabIndex = 4;
            this.txt_idMeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idMeli_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(742, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 37;
            this.label8.Text = "تاریخ تولد";
            // 
            // cmb_day
            // 
            this.cmb_day.FormattingEnabled = true;
            this.cmb_day.Items.AddRange(new object[] {
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.cmb_day.Location = new System.Drawing.Point(657, 77);
            this.cmb_day.Name = "cmb_day";
            this.cmb_day.Size = new System.Drawing.Size(38, 21);
            this.cmb_day.TabIndex = 5;
            this.cmb_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_day_KeyPress);
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmb_month.Location = new System.Drawing.Point(615, 77);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(36, 21);
            this.cmb_month.TabIndex = 6;
            this.cmb_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_month_KeyPress);
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_year.Location = new System.Drawing.Point(573, 77);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(36, 21);
            this.cmb_year.TabIndex = 7;
            this.cmb_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_year_KeyPress);
            // 
            // txt_reshteh
            // 
            this.txt_reshteh.Location = new System.Drawing.Point(573, 244);
            this.txt_reshteh.Name = "txt_reshteh";
            this.txt_reshteh.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_reshteh.Size = new System.Drawing.Size(122, 20);
            this.txt_reshteh.TabIndex = 11;
            this.txt_reshteh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reshteh_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(871, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_id.Size = new System.Drawing.Size(122, 20);
            this.txt_id.TabIndex = 24;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(710, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "میزان تحصیلات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(718, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "رشته تحصیلی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(1058, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "آدرس";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(573, 301);
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_address.Size = new System.Drawing.Size(420, 20);
            this.txt_address.TabIndex = 12;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_address_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(772, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 26);
            this.label10.TabIndex = 32;
            this.label10.Text = "تلفن";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(573, 120);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_tel.Size = new System.Drawing.Size(122, 20);
            this.txt_tel.TabIndex = 8;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(768, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "سمت";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(1058, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 26);
            this.label12.TabIndex = 31;
            this.label12.Text = "نام پدر";
            // 
            // txt_fatherName
            // 
            this.txt_fatherName.Location = new System.Drawing.Point(871, 164);
            this.txt_fatherName.Name = "txt_fatherName";
            this.txt_fatherName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_fatherName.Size = new System.Drawing.Size(122, 20);
            this.txt_fatherName.TabIndex = 2;
            this.txt_fatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fatherName_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(115, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 177);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.button1.Location = new System.Drawing.Point(115, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "برگشت";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_show.Image = global::project.Properties.Resources.folder_open;
            this.btn_show.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show.Location = new System.Drawing.Point(1002, 357);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(96, 37);
            this.btn_show.TabIndex = 16;
            this.btn_show.Text = "نمایش";
            this.btn_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.Image = global::project.Properties.Resources.gq_edit;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(756, 357);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(96, 37);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "ویرایش";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insert.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_insert.Image = global::project.Properties.Resources.gq_edit;
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_insert.Location = new System.Drawing.Point(881, 356);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(96, 37);
            this.btn_insert.TabIndex = 17;
            this.btn_insert.Text = "وارد کردن";
            this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_search.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.Location = new System.Drawing.Point(502, 357);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 37);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "جستجو";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_pic
            // 
            this.btn_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pic.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_pic.Image = global::project.Properties.Resources.search_rtl1;
            this.btn_pic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pic.Location = new System.Drawing.Point(115, 288);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(96, 40);
            this.btn_pic.TabIndex = 14;
            this.btn_pic.Text = "تصویر";
            this.btn_pic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.Image = global::project.Properties.Resources.gq_cmd_file_new;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(376, 355);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 38);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "پاک کردن";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.Image = global::project.Properties.Resources.gq_cmd_edit_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(629, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.Recovered_Png_11;
            this.pictureBox1.Location = new System.Drawing.Point(139, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(423, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 26);
            this.label13.TabIndex = 32;
            this.label13.Text = "تصویر";
            // 
            // txt_browser
            // 
            this.txt_browser.Location = new System.Drawing.Point(247, 298);
            this.txt_browser.Name = "txt_browser";
            this.txt_browser.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_browser.Size = new System.Drawing.Size(132, 20);
            this.txt_browser.TabIndex = 13;
            this.txt_browser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_browser_KeyPress);
            // 
            // cmb_semat
            // 
            this.cmb_semat.FormattingEnabled = true;
            this.cmb_semat.Items.AddRange(new object[] {
            "دکتر",
            "پذیرش1",
            "پذیرش2",
            "سایر"});
            this.cmb_semat.Location = new System.Drawing.Point(573, 164);
            this.cmb_semat.Name = "cmb_semat";
            this.cmb_semat.Size = new System.Drawing.Size(121, 21);
            this.cmb_semat.TabIndex = 9;
            this.cmb_semat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_semat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_semat_KeyPress);
            // 
            // cmb_degree
            // 
            this.cmb_degree.FormattingEnabled = true;
            this.cmb_degree.Items.AddRange(new object[] {
            "دکترا",
            "فوق لیسانس",
            "لیسانس",
            "فوق دیپلم",
            "دیپلم"});
            this.cmb_degree.Location = new System.Drawing.Point(574, 204);
            this.cmb_degree.Name = "cmb_degree";
            this.cmb_degree.Size = new System.Drawing.Size(121, 21);
            this.cmb_degree.TabIndex = 10;
            this.cmb_degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_degree_KeyPress);
            // 
            // help
            // 
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.help.Image = global::project.Properties.Resources.flpc_out_of_date;
            this.help.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.help.Location = new System.Drawing.Point(247, 353);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(96, 40);
            this.help.TabIndex = 15;
            this.help.Text = "راهنما";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            // 
            // مToolStripMenuItem
            // 
            this.مToolStripMenuItem.Name = "مToolStripMenuItem";
            this.مToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.مToolStripMenuItem.Text = "نمایش";
            this.مToolStripMenuItem.Click += new System.EventHandler(this.مToolStripMenuItem_Click);
            // 
            // personal_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 701);
            this.Controls.Add(this.help);
            this.Controls.Add(this.cmb_degree);
            this.Controls.Add(this.cmb_semat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.cmb_day);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_idMeli);
            this.Controls.Add(this.txt_idshenasname);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_browser);
            this.Controls.Add(this.txt_reshteh);
            this.Controls.Add(this.txt_family);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fatherName);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "personal_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پرسنل";
            this.Load += new System.EventHandler(this.personal_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idshenasname;
        private System.Windows.Forms.TextBox txt_family;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idMeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_day;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.TextBox txt_reshteh;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_fatherName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_browser;
        private System.Windows.Forms.ComboBox cmb_semat;
        private System.Windows.Forms.ComboBox cmb_degree;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مToolStripMenuItem;
    }
}