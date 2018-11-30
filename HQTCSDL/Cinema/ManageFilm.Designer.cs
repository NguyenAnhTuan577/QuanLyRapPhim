namespace Cinema
{
    partial class ManageFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFilm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSearchFilm = new System.Windows.Forms.TabPage();
            this.dtgvListFilm = new System.Windows.Forms.DataGridView();
            this.tb = new System.Windows.Forms.TextBox();
            this.lbFind = new System.Windows.Forms.Label();
            this.tpAddFilm = new System.Windows.Forms.TabPage();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDeleteFilm = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tpUpdateFilm = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpSearchFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFilm)).BeginInit();
            this.tpAddFilm.SuspendLayout();
            this.tpDeleteFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpUpdateFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSearchFilm);
            this.tabControl1.Controls.Add(this.tpAddFilm);
            this.tabControl1.Controls.Add(this.tpDeleteFilm);
            this.tabControl1.Controls.Add(this.tpUpdateFilm);
            this.tabControl1.Location = new System.Drawing.Point(1, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSearchFilm
            // 
            this.tpSearchFilm.Controls.Add(this.button5);
            this.tpSearchFilm.Controls.Add(this.dtgvListFilm);
            this.tpSearchFilm.Controls.Add(this.tb);
            this.tpSearchFilm.Controls.Add(this.lbFind);
            this.tpSearchFilm.Location = new System.Drawing.Point(4, 22);
            this.tpSearchFilm.Name = "tpSearchFilm";
            this.tpSearchFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchFilm.Size = new System.Drawing.Size(893, 471);
            this.tpSearchFilm.TabIndex = 0;
            this.tpSearchFilm.Text = "Tìm kiếm phim";
            this.tpSearchFilm.UseVisualStyleBackColor = true;
            // 
            // dtgvListFilm
            // 
            this.dtgvListFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFilm.Location = new System.Drawing.Point(3, 92);
            this.dtgvListFilm.Name = "dtgvListFilm";
            this.dtgvListFilm.Size = new System.Drawing.Size(887, 379);
            this.dtgvListFilm.TabIndex = 3;
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(300, 45);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(335, 26);
            this.tb.TabIndex = 2;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFind.Location = new System.Drawing.Point(148, 48);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(79, 20);
            this.lbFind.TabIndex = 0;
            this.lbFind.Text = "Tìm kiếm";
            // 
            // tpAddFilm
            // 
            this.tpAddFilm.Controls.Add(this.btnAddFilm);
            this.tpAddFilm.Controls.Add(this.textBox7);
            this.tpAddFilm.Controls.Add(this.textBox6);
            this.tpAddFilm.Controls.Add(this.textBox5);
            this.tpAddFilm.Controls.Add(this.textBox4);
            this.tpAddFilm.Controls.Add(this.textBox3);
            this.tpAddFilm.Controls.Add(this.textBox2);
            this.tpAddFilm.Controls.Add(this.textBox1);
            this.tpAddFilm.Controls.Add(this.label7);
            this.tpAddFilm.Controls.Add(this.label6);
            this.tpAddFilm.Controls.Add(this.label5);
            this.tpAddFilm.Controls.Add(this.label4);
            this.tpAddFilm.Controls.Add(this.label3);
            this.tpAddFilm.Controls.Add(this.label2);
            this.tpAddFilm.Controls.Add(this.label1);
            this.tpAddFilm.Location = new System.Drawing.Point(4, 22);
            this.tpAddFilm.Name = "tpAddFilm";
            this.tpAddFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddFilm.Size = new System.Drawing.Size(893, 471);
            this.tpAddFilm.TabIndex = 1;
            this.tpAddFilm.Text = "Thêm phim";
            this.tpAddFilm.UseVisualStyleBackColor = true;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.Location = new System.Drawing.Point(406, 415);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(103, 30);
            this.btnAddFilm.TabIndex = 14;
            this.btnAddFilm.Text = "Thêm";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(279, 112);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(230, 26);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(279, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 26);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(279, 197);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 26);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(279, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(279, 294);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(279, 345);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(279, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quốc gia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nội dung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đạo diễn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diễn viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm Sản Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim:";
            // 
            // tpDeleteFilm
            // 
            this.tpDeleteFilm.Controls.Add(this.button4);
            this.tpDeleteFilm.Controls.Add(this.dataGridView2);
            this.tpDeleteFilm.Controls.Add(this.textBox8);
            this.tpDeleteFilm.Controls.Add(this.button1);
            this.tpDeleteFilm.Location = new System.Drawing.Point(4, 22);
            this.tpDeleteFilm.Name = "tpDeleteFilm";
            this.tpDeleteFilm.Size = new System.Drawing.Size(893, 471);
            this.tpDeleteFilm.TabIndex = 2;
            this.tpDeleteFilm.Text = "Xóa phim";
            this.tpDeleteFilm.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(731, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-21, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(906, 324);
            this.dataGridView2.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(236, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(211, 26);
            this.textBox8.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(490, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tpUpdateFilm
            // 
            this.tpUpdateFilm.Controls.Add(this.button3);
            this.tpUpdateFilm.Controls.Add(this.dataGridView3);
            this.tpUpdateFilm.Controls.Add(this.textBox9);
            this.tpUpdateFilm.Controls.Add(this.button2);
            this.tpUpdateFilm.Location = new System.Drawing.Point(4, 22);
            this.tpUpdateFilm.Name = "tpUpdateFilm";
            this.tpUpdateFilm.Size = new System.Drawing.Size(893, 471);
            this.tpUpdateFilm.TabIndex = 3;
            this.tpUpdateFilm.Text = "Cập nhật phim";
            this.tpUpdateFilm.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(649, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-7, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(906, 324);
            this.dataGridView3.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(250, 55);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(211, 26);
            this.textBox9.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(736, 28);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbName.Location = new System.Drawing.Point(548, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(139, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Xin chào Nguyễn Anh Tuấn";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(714, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tìm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManageFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 564);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFilm";
            this.Text = "Quản lý phim";
            this.tabControl1.ResumeLayout(false);
            this.tpSearchFilm.ResumeLayout(false);
            this.tpSearchFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFilm)).EndInit();
            this.tpAddFilm.ResumeLayout(false);
            this.tpAddFilm.PerformLayout();
            this.tpDeleteFilm.ResumeLayout(false);
            this.tpDeleteFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpUpdateFilm.ResumeLayout(false);
            this.tpUpdateFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSearchFilm;
        private System.Windows.Forms.TabPage tpAddFilm;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TabPage tpDeleteFilm;
        private System.Windows.Forms.TabPage tpUpdateFilm;
        private System.Windows.Forms.DataGridView dtgvListFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button button5;
    }
}