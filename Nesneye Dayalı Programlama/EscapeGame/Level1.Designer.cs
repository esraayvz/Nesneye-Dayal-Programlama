namespace EscapeGame
{
    partial class Level1
    {
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
        //Dispose Metodu: Bu metod, formun kaynaklarını serbest bırakmak için kullanılır.Bir form kapatıldığında veya yok edildiğinde bu metot çalıştırılır.
        //panelInfo üzerinde oyunun bilgileri (puan, can, süre, seviye, vb.) görüntülenir. menuPanel ise oyun başlamadan önce kullanıcıya bir menü sunar.


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.isCont = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.labelHealt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelOyuncu = new System.Windows.Forms.Label();
            this.LvlTag = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPlayer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelInfo.Controls.Add(this.isCont);
            this.panelInfo.Controls.Add(this.labelPlayer);
            this.panelInfo.Controls.Add(this.labelScore);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.levelLabel);
            this.panelInfo.Controls.Add(this.labelHealt);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelSure);
            this.panelInfo.Controls.Add(this.labelUser);
            this.panelInfo.Controls.Add(this.labelOyuncu);
            this.panelInfo.Controls.Add(this.LvlTag);
            this.panelInfo.Controls.Add(this.labelTime);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1155, 51);
            this.panelInfo.TabIndex = 7;
            // 
            // isCont
            // 
            this.isCont.AutoSize = true;
            this.isCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isCont.Location = new System.Drawing.Point(419, 15);
            this.isCont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isCont.Name = "isCont";
            this.isCont.Size = new System.Drawing.Size(0, 24);
            this.isCont.TabIndex = 13;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(908, 16);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(67, 22);
            this.labelPlayer.TabIndex = 12;
            this.labelPlayer.Text = "Player";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(78, 16);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(21, 23);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Puan:";
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(1101, 14);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(18, 23);
            this.levelLabel.TabIndex = 9;
            this.levelLabel.Text = "1";
            // 
            // labelHealt
            // 
            this.labelHealt.AutoSize = true;
            this.labelHealt.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHealt.Location = new System.Drawing.Point(393, 14);
            this.labelHealt.Name = "labelHealt";
            this.labelHealt.Size = new System.Drawing.Size(21, 23);
            this.labelHealt.TabIndex = 8;
            this.labelHealt.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kalan Can:";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSure.Location = new System.Drawing.Point(514, 14);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(57, 22);
            this.labelSure.TabIndex = 6;
            this.labelSure.Text = "Süre:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUser.Location = new System.Drawing.Point(980, 10);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 24);
            this.labelUser.TabIndex = 5;
            // 
            // labelOyuncu
            // 
            this.labelOyuncu.AutoSize = true;
            this.labelOyuncu.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOyuncu.Location = new System.Drawing.Point(816, 17);
            this.labelOyuncu.Name = "labelOyuncu";
            this.labelOyuncu.Size = new System.Drawing.Size(87, 22);
            this.labelOyuncu.TabIndex = 4;
            this.labelOyuncu.Text = "Oyuncu:";
            // 
            // LvlTag
            // 
            this.LvlTag.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LvlTag.AutoSize = true;
            this.LvlTag.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvlTag.Location = new System.Drawing.Point(1011, 14);
            this.LvlTag.Name = "LvlTag";
            this.LvlTag.Size = new System.Drawing.Size(84, 22);
            this.LvlTag.TabIndex = 3;
            this.LvlTag.Text = "LEVEL:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(577, 13);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(60, 26);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelMain.Controls.Add(this.menuPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 51);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1155, 636);
            this.panelMain.TabIndex = 8;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuPanel.Controls.Add(this.pictureBox5);
            this.menuPanel.Controls.Add(this.label7);
            this.menuPanel.Controls.Add(this.pictureBox4);
            this.menuPanel.Controls.Add(this.pictureBox3);
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.linkLabel1);
            this.menuPanel.Controls.Add(this.label3);
            this.menuPanel.Controls.Add(this.label4);
            this.menuPanel.Controls.Add(this.textPlayer);
            this.menuPanel.Controls.Add(this.label5);
            this.menuPanel.Controls.Add(this.label6);
            this.menuPanel.Location = new System.Drawing.Point(0, 2);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1153, 635);
            this.menuPanel.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EscapeGame.Properties.Resources.Hero;
            this.pictureBox5.Location = new System.Drawing.Point(904, 236);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(163, 254);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(606, 44);
            this.label7.TabIndex = 20;
            this.label7.Text = "Oyunu durdurmak için P tuşuna, devam etmek için space tuşuna basınız.\r\n\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EscapeGame.Properties.Resources.info;
            this.pictureBox4.Location = new System.Drawing.Point(165, 302);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EscapeGame.Properties.Resources.info;
            this.pictureBox3.Location = new System.Drawing.Point(165, 443);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EscapeGame.Properties.Resources.info;
            this.pictureBox2.Location = new System.Drawing.Point(165, 373);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EscapeGame.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(165, 236);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(478, 456);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 22);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "tıklayınız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Skor tablosunu görmek için\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yön tuşlarını kullanmak karakterinizi hareket ettirir.\r\n";
            // 
            // textPlayer
            // 
            this.textPlayer.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlayer.Location = new System.Drawing.Point(451, 79);
            this.textPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.textPlayer.Name = "textPlayer";
            this.textPlayer.Size = new System.Drawing.Size(317, 30);
            this.textPlayer.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(566, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oyuncu adınızı girdikten sonra enter tuşuna basarsanız oyun başlar.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Oyuncu Adı:";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelOyuncu;
        private System.Windows.Forms.Label LvlTag;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelHealt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label isCont;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

