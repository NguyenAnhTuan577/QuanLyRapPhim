namespace Cinema
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lbName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSchetistic = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnShowtimes = new System.Windows.Forms.Button();
            this.btnAddAccountSeller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbName.Location = new System.Drawing.Point(253, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(139, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Xin chào Nguyễn Anh Tuấn";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(415, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSchetistic
            // 
            this.btnSchetistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchetistic.Location = new System.Drawing.Point(45, 239);
            this.btnSchetistic.Name = "btnSchetistic";
            this.btnSchetistic.Size = new System.Drawing.Size(181, 125);
            this.btnSchetistic.TabIndex = 2;
            this.btnSchetistic.Text = "Thống kê";
            this.btnSchetistic.UseVisualStyleBackColor = true;
            this.btnSchetistic.Click += new System.EventHandler(this.btnSchetistic_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Location = new System.Drawing.Point(45, 93);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(181, 122);
            this.btnFilm.TabIndex = 3;
            this.btnFilm.Text = "Quản lý phim";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnShowtimes
            // 
            this.btnShowtimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtimes.Location = new System.Drawing.Point(318, 93);
            this.btnShowtimes.Name = "btnShowtimes";
            this.btnShowtimes.Size = new System.Drawing.Size(172, 122);
            this.btnShowtimes.TabIndex = 4;
            this.btnShowtimes.Text = "Quản lý lịch chiếu";
            this.btnShowtimes.UseVisualStyleBackColor = true;
            this.btnShowtimes.Click += new System.EventHandler(this.btnShowtimes_Click);
            // 
            // btnAddAccountSeller
            // 
            this.btnAddAccountSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccountSeller.Location = new System.Drawing.Point(318, 239);
            this.btnAddAccountSeller.Name = "btnAddAccountSeller";
            this.btnAddAccountSeller.Size = new System.Drawing.Size(172, 125);
            this.btnAddAccountSeller.TabIndex = 5;
            this.btnAddAccountSeller.Text = "Đăng kí tài khoản cho nhân viên bán vé";
            this.btnAddAccountSeller.UseVisualStyleBackColor = true;
            this.btnAddAccountSeller.Click += new System.EventHandler(this.btnAddAccountSeller_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 400);
            this.Controls.Add(this.btnAddAccountSeller);
            this.Controls.Add(this.btnShowtimes);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnSchetistic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Hệ thống của Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSchetistic;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnShowtimes;
        private System.Windows.Forms.Button btnAddAccountSeller;
    }
}