namespace StokTakip
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.unlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.untext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unlabel
            // 
            this.unlabel.AutoSize = true;
            this.unlabel.Location = new System.Drawing.Point(87, 58);
            this.unlabel.Name = "unlabel";
            this.unlabel.Size = new System.Drawing.Size(64, 13);
            this.unlabel.TabIndex = 5;
            this.unlabel.Text = "Username : ";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Location = new System.Drawing.Point(89, 105);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(62, 13);
            this.passlabel.TabIndex = 5;
            this.passlabel.Text = "Password : ";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(209, 148);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(80, 39);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(92, 148);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(83, 39);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // untext
            // 
            this.untext.Location = new System.Drawing.Point(165, 58);
            this.untext.Name = "untext";
            this.untext.Size = new System.Drawing.Size(124, 20);
            this.untext.TabIndex = 0;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(165, 102);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(124, 20);
            this.passtext.TabIndex = 1;
            this.passtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passtext_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 236);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.untext);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.unlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox untext;
        private System.Windows.Forms.TextBox passtext;
    }
}

