namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rainyPicture = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cloudyPicture = new System.Windows.Forms.PictureBox();
            this.clearNight = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.snowyPicture = new System.Windows.Forms.PictureBox();
            this.Sunny = new System.Windows.Forms.PictureBox();
            this.windy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "London UK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "DAY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(191, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 58);
            this.label4.TabIndex = 3;
            this.label4.Text = "00.00ᶜ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(67, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wind:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(141, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Today";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(67, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Humidity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(178, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Today";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.windy;
            this.pictureBox2.Location = new System.Drawing.Point(12, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // rainyPicture
            // 
            this.rainyPicture.BackColor = System.Drawing.Color.Transparent;
            this.rainyPicture.ErrorImage = null;
            this.rainyPicture.Image = global::WindowsFormsApp1.Properties.Resources.rainy;
            this.rainyPicture.InitialImage = null;
            this.rainyPicture.Location = new System.Drawing.Point(222, 136);
            this.rainyPicture.Name = "rainyPicture";
            this.rainyPicture.Size = new System.Drawing.Size(120, 112);
            this.rainyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rainyPicture.TabIndex = 6;
            this.rainyPicture.TabStop = false;
            this.rainyPicture.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(189, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Today";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(67, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pressure:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(293, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Today";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(31, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 29);
            this.label13.TabIndex = 14;
            this.label13.Text = "The Felt Temperature:\r\n";
            // 
            // cloudyPicture
            // 
            this.cloudyPicture.BackColor = System.Drawing.Color.Transparent;
            this.cloudyPicture.ErrorImage = null;
            this.cloudyPicture.Image = ((System.Drawing.Image)(resources.GetObject("cloudyPicture.Image")));
            this.cloudyPicture.InitialImage = null;
            this.cloudyPicture.Location = new System.Drawing.Point(222, 136);
            this.cloudyPicture.Name = "cloudyPicture";
            this.cloudyPicture.Size = new System.Drawing.Size(120, 112);
            this.cloudyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cloudyPicture.TabIndex = 16;
            this.cloudyPicture.TabStop = false;
            this.cloudyPicture.Visible = false;
            // 
            // clearNight
            // 
            this.clearNight.BackColor = System.Drawing.Color.Transparent;
            this.clearNight.ErrorImage = null;
            this.clearNight.Image = ((System.Drawing.Image)(resources.GetObject("clearNight.Image")));
            this.clearNight.InitialImage = null;
            this.clearNight.Location = new System.Drawing.Point(222, 136);
            this.clearNight.Name = "clearNight";
            this.clearNight.Size = new System.Drawing.Size(120, 112);
            this.clearNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clearNight.TabIndex = 17;
            this.clearNight.TabStop = false;
            this.clearNight.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(5, 343);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // snowyPicture
            // 
            this.snowyPicture.BackColor = System.Drawing.Color.Transparent;
            this.snowyPicture.ErrorImage = null;
            this.snowyPicture.Image = ((System.Drawing.Image)(resources.GetObject("snowyPicture.Image")));
            this.snowyPicture.InitialImage = null;
            this.snowyPicture.Location = new System.Drawing.Point(222, 136);
            this.snowyPicture.Name = "snowyPicture";
            this.snowyPicture.Size = new System.Drawing.Size(120, 112);
            this.snowyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.snowyPicture.TabIndex = 20;
            this.snowyPicture.TabStop = false;
            this.snowyPicture.Visible = false;
            this.snowyPicture.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Sunny
            // 
            this.Sunny.BackColor = System.Drawing.Color.Transparent;
            this.Sunny.ErrorImage = null;
            this.Sunny.Image = ((System.Drawing.Image)(resources.GetObject("Sunny.Image")));
            this.Sunny.InitialImage = null;
            this.Sunny.Location = new System.Drawing.Point(222, 136);
            this.Sunny.Name = "Sunny";
            this.Sunny.Size = new System.Drawing.Size(120, 112);
            this.Sunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sunny.TabIndex = 21;
            this.Sunny.TabStop = false;
            this.Sunny.Visible = false;
            // 
            // windy
            // 
            this.windy.BackColor = System.Drawing.Color.Transparent;
            this.windy.ErrorImage = null;
            this.windy.Image = ((System.Drawing.Image)(resources.GetObject("windy.Image")));
            this.windy.InitialImage = null;
            this.windy.Location = new System.Drawing.Point(222, 136);
            this.windy.Name = "windy";
            this.windy.Size = new System.Drawing.Size(120, 112);
            this.windy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.windy.TabIndex = 22;
            this.windy.TabStop = false;
            this.windy.Visible = false;
            this.windy.Click += new System.EventHandler(this.windy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.şema;
            this.ClientSize = new System.Drawing.Size(397, 587);
            this.Controls.Add(this.windy);
            this.Controls.Add(this.Sunny);
            this.Controls.Add(this.snowyPicture);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.clearNight);
            this.Controls.Add(this.cloudyPicture);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rainyPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.PictureBox rainyPicture;
        public System.Windows.Forms.PictureBox cloudyPicture;
        public System.Windows.Forms.PictureBox clearNight;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox snowyPicture;
        public System.Windows.Forms.PictureBox Sunny;
        public System.Windows.Forms.PictureBox windy;
    }
}

