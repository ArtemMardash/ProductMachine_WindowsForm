namespace ProductMachine_WindowsForm
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoneyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyGoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.addMoneyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(459, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 31);
            this.numericUpDown1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add value",
            "Get Change",
            "Buy Good"});
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comboBox2.Location = new System.Drawing.Point(230, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Price,
            this.Count});
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(578, 225);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            this.Count.Width = 150;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoneyToolStripMenuItem,
            this.getChangeToolStripMenuItem,
            this.buyGoodToolStripMenuItem,
            this.addMoneyToolStripMenuItem2});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addMoneyToolStripMenuItem
            // 
            this.addMoneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.editProductToolStripMenuItem,
            this.addMoneyToolStripMenuItem1,
            this.takeMoneyToolStripMenuItem});
            this.addMoneyToolStripMenuItem.Name = "addMoneyToolStripMenuItem";
            this.addMoneyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addMoneyToolStripMenuItem.Text = "As developer";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.addToolStripMenuItem.Text = "Add product";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.deleteProductToolStripMenuItem.Text = "Delete product";
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.editProductToolStripMenuItem.Text = "Edit product";
            // 
            // addMoneyToolStripMenuItem1
            // 
            this.addMoneyToolStripMenuItem1.Name = "addMoneyToolStripMenuItem1";
            this.addMoneyToolStripMenuItem1.Size = new System.Drawing.Size(232, 34);
            this.addMoneyToolStripMenuItem1.Text = "Add money";
            // 
            // takeMoneyToolStripMenuItem
            // 
            this.takeMoneyToolStripMenuItem.Name = "takeMoneyToolStripMenuItem";
            this.takeMoneyToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.takeMoneyToolStripMenuItem.Text = "Take money";
            // 
            // getChangeToolStripMenuItem
            // 
            this.getChangeToolStripMenuItem.Name = "getChangeToolStripMenuItem";
            this.getChangeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.getChangeToolStripMenuItem.Text = "Get Change";
            this.getChangeToolStripMenuItem.Click += new System.EventHandler(this.getChangeToolStripMenuItem_Click);
            // 
            // buyGoodToolStripMenuItem
            // 
            this.buyGoodToolStripMenuItem.Name = "buyGoodToolStripMenuItem";
            this.buyGoodToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buyGoodToolStripMenuItem.Text = "Buy good";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Balance:";
            // 
            // addMoneyToolStripMenuItem2
            // 
            this.addMoneyToolStripMenuItem2.Name = "addMoneyToolStripMenuItem2";
            this.addMoneyToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.addMoneyToolStripMenuItem2.Text = "Add money";
            this.addMoneyToolStripMenuItem2.Click += new System.EventHandler(this.addMoneyToolStripMenuItem2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem addMoneyToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteProductToolStripMenuItem;
        private ToolStripMenuItem editProductToolStripMenuItem;
        private ToolStripMenuItem addMoneyToolStripMenuItem1;
        private ToolStripMenuItem takeMoneyToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Count;
        private ToolStripMenuItem getChangeToolStripMenuItem;
        private ToolStripMenuItem buyGoodToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem addMoneyToolStripMenuItem2;
    }
}