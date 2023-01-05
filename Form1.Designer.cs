
namespace Auto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.txtcaptch = new System.Windows.Forms.TextBox();
            this.Ibcaptcha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.artanPanel1 = new Auto.ArtanPanel();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cButton2 = new Auto.CButton();
            this.cButton1 = new Auto.CButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(317, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.ForeColor = System.Drawing.Color.Gray;
            this.textBox_login.Location = new System.Drawing.Point(398, 220);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_login.MaxLength = 50;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(219, 22);
            this.textBox_login.TabIndex = 9;
            this.textBox_login.Text = "example@mail.ru";
            this.textBox_login.Enter += new System.EventHandler(this.textBox_login_Enter);
            this.textBox_login.Leave += new System.EventHandler(this.textBox_login_Leave);
            // 
            // txtcaptch
            // 
            this.txtcaptch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcaptch.Location = new System.Drawing.Point(398, 314);
            this.txtcaptch.Margin = new System.Windows.Forms.Padding(4);
            this.txtcaptch.Name = "txtcaptch";
            this.txtcaptch.Size = new System.Drawing.Size(102, 22);
            this.txtcaptch.TabIndex = 11;
            // 
            // Ibcaptcha
            // 
            this.Ibcaptcha.AutoSize = true;
            this.Ibcaptcha.BackColor = System.Drawing.Color.White;
            this.Ibcaptcha.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibcaptcha.Location = new System.Drawing.Point(393, 284);
            this.Ibcaptcha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ibcaptcha.Name = "Ibcaptcha";
            this.Ibcaptcha.Size = new System.Drawing.Size(103, 24);
            this.Ibcaptcha.TabIndex = 12;
            this.Ibcaptcha.Text = "captcha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Авторизация";
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 40;
            this.artanPanel1.Controls.Add(this.textBox_password);
            this.artanPanel1.Controls.Add(this.linkLabel2);
            this.artanPanel1.Controls.Add(this.cButton2);
            this.artanPanel1.Controls.Add(this.cButton1);
            this.artanPanel1.Controls.Add(this.pictureBox3);
            this.artanPanel1.Controls.Add(this.pictureBox4);
            this.artanPanel1.Controls.Add(this.linkLabel1);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel1.Location = new System.Drawing.Point(291, 51);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(383, 405);
            this.artanPanel1.TabIndex = 27;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.Color.Gray;
            this.textBox_password.Location = new System.Drawing.Point(107, 202);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(219, 22);
            this.textBox_password.TabIndex = 28;
            this.textBox_password.Text = "Более 8 символов";
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel2.Location = new System.Drawing.Point(134, 289);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(128, 16);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Забыли пароль?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cButton2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.cButton2.BorderColor = System.Drawing.Color.Black;
            this.cButton2.BorderRadius = 13;
            this.cButton2.BorderSize = 0;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(219, 229);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(106, 28);
            this.cButton2.TabIndex = 28;
            this.cButton2.Text = "Обновить";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.cButton2_Click);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.cButton1.BorderColor = System.Drawing.Color.Black;
            this.cButton1.BorderRadius = 20;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(99, 324);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(197, 50);
            this.cButton1.TabIndex = 28;
            this.cButton1.Text = "Вход";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Auto.Properties.Resources.show_icon_153436;
            this.pictureBox3.InitialImage = global::Auto.Properties.Resources.F9RogVWvcWGqHPdOLPWnCw__1_;
            this.pictureBox3.Location = new System.Drawing.Point(333, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Auto.Properties.Resources.eye_slash_visible_hide_hidden_show_icon_145987;
            this.pictureBox4.InitialImage = global::Auto.Properties.Resources.F9RogVWvcWGqHPdOLPWnCw__1_;
            this.pictureBox4.Location = new System.Drawing.Point(333, 199);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 31);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.Location = new System.Drawing.Point(125, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ещё нет аккаунта?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Капча";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Auto.Properties.Resources.logoza_ru;
            this.pictureBox1.InitialImage = global::Auto.Properties.Resources.F9RogVWvcWGqHPdOLPWnCw__1_;
            this.pictureBox1.Location = new System.Drawing.Point(309, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Auto.Properties.Resources.RIO_remont_fitnes_tsentrov_bassejnov_spa_v_Ekaterinburge4;
            this.pictureBox2.InitialImage = global::Auto.Properties.Resources.F9RogVWvcWGqHPdOLPWnCw__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(955, 548);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ibcaptcha);
            this.Controls.Add(this.txtcaptch);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox txtcaptch;
        private System.Windows.Forms.Label Ibcaptcha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ArtanPanel artanPanel1;
        private CButton cButton1;
        private CButton cButton2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

