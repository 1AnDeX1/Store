
namespace Store
{
    partial class FormForAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAddRow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonManufacturerInfo = new System.Windows.Forms.Button();
            this.buttonSupplierInfo = new System.Windows.Forms.Button();
            this.buttonSellerInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGood = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonManufacturer = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonSeller = new System.Windows.Forms.Button();
            this.buttonMinusGood = new System.Windows.Forms.Button();
            this.buttonMinusManufacturer = new System.Windows.Forms.Button();
            this.buttonMinusSupplier = new System.Windows.Forms.Button();
            this.buttonMinusSeller = new System.Windows.Forms.Button();
            this.textBoxValueChange = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1270, 672);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // labelAddRow
            // 
            this.labelAddRow.AutoSize = true;
            this.labelAddRow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddRow.Location = new System.Drawing.Point(119, 77);
            this.labelAddRow.Name = "labelAddRow";
            this.labelAddRow.Size = new System.Drawing.Size(87, 28);
            this.labelAddRow.TabIndex = 2;
            this.labelAddRow.Text = "Add row";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(119, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(172, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonManufacturerInfo
            // 
            this.buttonManufacturerInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManufacturerInfo.Location = new System.Drawing.Point(551, 105);
            this.buttonManufacturerInfo.Name = "buttonManufacturerInfo";
            this.buttonManufacturerInfo.Size = new System.Drawing.Size(122, 43);
            this.buttonManufacturerInfo.TabIndex = 5;
            this.buttonManufacturerInfo.Text = "Info";
            this.buttonManufacturerInfo.UseVisualStyleBackColor = true;
            this.buttonManufacturerInfo.Click += new System.EventHandler(this.buttonManufacturerInfo_Click);
            // 
            // buttonSupplierInfo
            // 
            this.buttonSupplierInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupplierInfo.Location = new System.Drawing.Point(700, 106);
            this.buttonSupplierInfo.Name = "buttonSupplierInfo";
            this.buttonSupplierInfo.Size = new System.Drawing.Size(122, 43);
            this.buttonSupplierInfo.TabIndex = 6;
            this.buttonSupplierInfo.Text = "Info";
            this.buttonSupplierInfo.UseVisualStyleBackColor = true;
            this.buttonSupplierInfo.Click += new System.EventHandler(this.buttonSupplierInfo_Click);
            // 
            // buttonSellerInfo
            // 
            this.buttonSellerInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSellerInfo.Location = new System.Drawing.Point(846, 106);
            this.buttonSellerInfo.Name = "buttonSellerInfo";
            this.buttonSellerInfo.Size = new System.Drawing.Size(122, 43);
            this.buttonSellerInfo.TabIndex = 7;
            this.buttonSellerInfo.Text = "Info";
            this.buttonSellerInfo.UseVisualStyleBackColor = true;
            this.buttonSellerInfo.Click += new System.EventHandler(this.buttonSellerInfo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1499, 659);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 31);
            this.textBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1677, 656);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Dismiss";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1302, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change amount of product:";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSell.Location = new System.Drawing.Point(1745, 142);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(61, 40);
            this.buttonSell.TabIndex = 12;
            this.buttonSell.Text = "-";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1808, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1899, 38);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1899, 39);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 34);
            this.toolStripButton1.Text = "Reload";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(232, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 34);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "New manufacturer price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chooce product:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(232, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 34);
            this.textBox3.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(393, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 74);
            this.button5.TabIndex = 20;
            this.button5.Text = "Count";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Choose good:";
            // 
            // textBoxGood
            // 
            this.textBoxGood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGood.Location = new System.Drawing.Point(211, 31);
            this.textBoxGood.Name = "textBoxGood";
            this.textBoxGood.Size = new System.Drawing.Size(142, 34);
            this.textBoxGood.TabIndex = 22;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxManufacturer.Location = new System.Drawing.Point(211, 75);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(142, 34);
            this.textBoxManufacturer.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Choose manufacturer:";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplier.Location = new System.Drawing.Point(211, 121);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(142, 34);
            this.textBoxSupplier.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Choose supplier:";
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSeller.Location = new System.Drawing.Point(211, 169);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.Size = new System.Drawing.Size(142, 34);
            this.textBoxSeller.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Choose seller:";
            // 
            // buttonGood
            // 
            this.buttonGood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGood.Location = new System.Drawing.Point(367, 28);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(145, 34);
            this.buttonGood.TabIndex = 29;
            this.buttonGood.Text = "Give a mark";
            this.buttonGood.UseVisualStyleBackColor = true;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            // 
            // buttonManufacturer
            // 
            this.buttonManufacturer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManufacturer.Location = new System.Drawing.Point(366, 75);
            this.buttonManufacturer.Name = "buttonManufacturer";
            this.buttonManufacturer.Size = new System.Drawing.Size(145, 34);
            this.buttonManufacturer.TabIndex = 30;
            this.buttonManufacturer.Text = "Give a mark";
            this.buttonManufacturer.UseVisualStyleBackColor = true;
            this.buttonManufacturer.Click += new System.EventHandler(this.buttonManufacturer_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupplier.Location = new System.Drawing.Point(367, 119);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(145, 34);
            this.buttonSupplier.TabIndex = 31;
            this.buttonSupplier.Text = "Give a mark";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonSeller
            // 
            this.buttonSeller.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSeller.Location = new System.Drawing.Point(367, 167);
            this.buttonSeller.Name = "buttonSeller";
            this.buttonSeller.Size = new System.Drawing.Size(145, 34);
            this.buttonSeller.TabIndex = 32;
            this.buttonSeller.Text = "Give a mark";
            this.buttonSeller.UseVisualStyleBackColor = true;
            this.buttonSeller.Click += new System.EventHandler(this.buttonSeller_Click);
            // 
            // buttonMinusGood
            // 
            this.buttonMinusGood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusGood.Location = new System.Drawing.Point(518, 27);
            this.buttonMinusGood.Name = "buttonMinusGood";
            this.buttonMinusGood.Size = new System.Drawing.Size(59, 34);
            this.buttonMinusGood.TabIndex = 33;
            this.buttonMinusGood.Text = "-";
            this.buttonMinusGood.UseVisualStyleBackColor = true;
            this.buttonMinusGood.Click += new System.EventHandler(this.buttonMinusGood_Click);
            // 
            // buttonMinusManufacturer
            // 
            this.buttonMinusManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusManufacturer.Location = new System.Drawing.Point(518, 75);
            this.buttonMinusManufacturer.Name = "buttonMinusManufacturer";
            this.buttonMinusManufacturer.Size = new System.Drawing.Size(59, 34);
            this.buttonMinusManufacturer.TabIndex = 34;
            this.buttonMinusManufacturer.Text = "-";
            this.buttonMinusManufacturer.UseVisualStyleBackColor = true;
            this.buttonMinusManufacturer.Click += new System.EventHandler(this.buttonMinusManufacturer_Click);
            // 
            // buttonMinusSupplier
            // 
            this.buttonMinusSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusSupplier.Location = new System.Drawing.Point(517, 121);
            this.buttonMinusSupplier.Name = "buttonMinusSupplier";
            this.buttonMinusSupplier.Size = new System.Drawing.Size(59, 31);
            this.buttonMinusSupplier.TabIndex = 35;
            this.buttonMinusSupplier.Text = "-";
            this.buttonMinusSupplier.UseVisualStyleBackColor = true;
            this.buttonMinusSupplier.Click += new System.EventHandler(this.buttonMinusSupplier_Click);
            // 
            // buttonMinusSeller
            // 
            this.buttonMinusSeller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinusSeller.Location = new System.Drawing.Point(517, 167);
            this.buttonMinusSeller.Name = "buttonMinusSeller";
            this.buttonMinusSeller.Size = new System.Drawing.Size(59, 34);
            this.buttonMinusSeller.TabIndex = 36;
            this.buttonMinusSeller.Text = "-";
            this.buttonMinusSeller.UseVisualStyleBackColor = true;
            this.buttonMinusSeller.Click += new System.EventHandler(this.buttonMinusSeller_Click);
            // 
            // textBoxValueChange
            // 
            this.textBoxValueChange.Location = new System.Drawing.Point(1607, 151);
            this.textBoxValueChange.Name = "textBoxValueChange";
            this.textBoxValueChange.Size = new System.Drawing.Size(130, 31);
            this.textBoxValueChange.TabIndex = 37;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(1294, 793);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(195, 31);
            this.textBoxSearch.TabIndex = 38;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(1517, 746);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 78);
            this.buttonSearch.TabIndex = 39;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1294, 746);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 40;
            this.label8.Text = "Find good:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1294, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 30);
            this.label9.TabIndex = 41;
            this.label9.Text = "Dismiss seller:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxGood);
            this.groupBox1.Controls.Add(this.buttonSeller);
            this.groupBox1.Controls.Add(this.buttonSupplier);
            this.groupBox1.Controls.Add(this.buttonManufacturer);
            this.groupBox1.Controls.Add(this.buttonGood);
            this.groupBox1.Controls.Add(this.textBoxSeller);
            this.groupBox1.Controls.Add(this.buttonMinusSeller);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonMinusSupplier);
            this.groupBox1.Controls.Add(this.textBoxSupplier);
            this.groupBox1.Controls.Add(this.buttonMinusManufacturer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonMinusGood);
            this.groupBox1.Controls.Add(this.textBoxManufacturer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1294, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 230);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mark the best:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1300, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 120);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1457, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "(click on product you wanna change)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(551, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "Manufacturer:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(700, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 30);
            this.label12.TabIndex = 47;
            this.label12.Text = "Supplier:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(846, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 30);
            this.label13.TabIndex = 48;
            this.label13.Text = "Seller:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1706, 746);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 77);
            this.button6.TabIndex = 49;
            this.button6.Text = "Log out";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 932);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxValueChange);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSellerInfo);
            this.Controls.Add(this.buttonSupplierInfo);
            this.Controls.Add(this.buttonManufacturerInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAddRow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormForAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddRow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonManufacturerInfo;
        private System.Windows.Forms.Button buttonSupplierInfo;
        private System.Windows.Forms.Button buttonSellerInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGood;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonManufacturer;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonSeller;
        private System.Windows.Forms.Button buttonMinusGood;
        private System.Windows.Forms.Button buttonMinusManufacturer;
        private System.Windows.Forms.Button buttonMinusSupplier;
        private System.Windows.Forms.Button buttonMinusSeller;
        private System.Windows.Forms.TextBox textBoxValueChange;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button6;
    }
}

