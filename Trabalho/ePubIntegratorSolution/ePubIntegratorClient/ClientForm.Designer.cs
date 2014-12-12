namespace ePubIntegratorClient
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonChapters = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFav = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookPath = new System.Windows.Forms.TextBox();
            this.buttonBookPath = new System.Windows.Forms.Button();
            this.buttonBookmark = new System.Windows.Forms.Button();
            this.buttonFavorite = new System.Windows.Forms.Button();
            this.checkBoxFav = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(50, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(102, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "loading user name...";
            // 
            // buttonStats
            // 
            this.buttonStats.Image = ((System.Drawing.Image)(resources.GetObject("buttonStats.Image")));
            this.buttonStats.Location = new System.Drawing.Point(496, 9);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(40, 40);
            this.buttonStats.TabIndex = 5;
            this.buttonStats.UseVisualStyleBackColor = true;
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.Location = new System.Drawing.Point(6, 51);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(205, 225);
            this.listBooks.TabIndex = 6;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.listBooks_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxFav);
            this.panel1.Controls.Add(this.buttonBookmark);
            this.panel1.Controls.Add(this.buttonFavorite);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonChapters);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBookPath);
            this.panel1.Controls.Add(this.buttonBookPath);
            this.panel1.Controls.Add(this.listBooks);
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 286);
            this.panel1.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(179, 13);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(32, 32);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // buttonChapters
            // 
            this.buttonChapters.Image = ((System.Drawing.Image)(resources.GetObject("buttonChapters.Image")));
            this.buttonChapters.Location = new System.Drawing.Point(265, 3);
            this.buttonChapters.Name = "buttonChapters";
            this.buttonChapters.Size = new System.Drawing.Size(42, 42);
            this.buttonChapters.TabIndex = 4;
            this.buttonChapters.UseVisualStyleBackColor = true;
            this.buttonChapters.Click += new System.EventHandler(this.buttonChapters_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelDesc);
            this.panel2.Controls.Add(this.labelSubject);
            this.panel2.Controls.Add(this.labelCreator);
            this.panel2.Controls.Add(this.labelLanguage);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.labelPublisher);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBoxFav);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(217, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 225);
            this.panel2.TabIndex = 9;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(72, 104);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(10, 13);
            this.labelDesc.TabIndex = 14;
            this.labelDesc.Text = "-";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(55, 91);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(10, 13);
            this.labelSubject.TabIndex = 13;
            this.labelSubject.Text = "-";
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Location = new System.Drawing.Point(53, 39);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(10, 13);
            this.labelCreator.TabIndex = 12;
            this.labelCreator.Text = "-";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(67, 52);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(10, 13);
            this.labelLanguage.TabIndex = 8;
            this.labelLanguage.Text = "-";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(42, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(10, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "-";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(62, 78);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(10, 13);
            this.labelPublisher.TabIndex = 10;
            this.labelPublisher.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Creator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxFav
            // 
            this.pictureBoxFav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFav.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFav.Image")));
            this.pictureBoxFav.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFav.Name = "pictureBoxFav";
            this.pictureBoxFav.Size = new System.Drawing.Size(29, 29);
            this.pictureBoxFav.TabIndex = 3;
            this.pictureBoxFav.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(69, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(10, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publisher:";
            // 
            // buttonRead
            // 
            this.buttonRead.Image = ((System.Drawing.Image)(resources.GetObject("buttonRead.Image")));
            this.buttonRead.Location = new System.Drawing.Point(217, 3);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(42, 42);
            this.buttonRead.TabIndex = 3;
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Path:";
            // 
            // textBoxBookPath
            // 
            this.textBoxBookPath.Location = new System.Drawing.Point(6, 25);
            this.textBoxBookPath.Name = "textBoxBookPath";
            this.textBoxBookPath.Size = new System.Drawing.Size(129, 20);
            this.textBoxBookPath.TabIndex = 8;
            this.textBoxBookPath.Text = "C:\\Users\\Go0rum\\Documents\\Books";
            // 
            // buttonBookPath
            // 
            this.buttonBookPath.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookPath.Image")));
            this.buttonBookPath.Location = new System.Drawing.Point(141, 13);
            this.buttonBookPath.Name = "buttonBookPath";
            this.buttonBookPath.Size = new System.Drawing.Size(32, 32);
            this.buttonBookPath.TabIndex = 7;
            this.buttonBookPath.UseVisualStyleBackColor = true;
            this.buttonBookPath.Click += new System.EventHandler(this.buttonBookPath_Click);
            // 
            // buttonBookmark
            // 
            this.buttonBookmark.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookmark.Image")));
            this.buttonBookmark.Location = new System.Drawing.Point(361, 3);
            this.buttonBookmark.Name = "buttonBookmark";
            this.buttonBookmark.Size = new System.Drawing.Size(42, 42);
            this.buttonBookmark.TabIndex = 12;
            this.buttonBookmark.UseVisualStyleBackColor = true;
            // 
            // buttonFavorite
            // 
            this.buttonFavorite.Image = ((System.Drawing.Image)(resources.GetObject("buttonFavorite.Image")));
            this.buttonFavorite.Location = new System.Drawing.Point(313, 3);
            this.buttonFavorite.Name = "buttonFavorite";
            this.buttonFavorite.Size = new System.Drawing.Size(42, 42);
            this.buttonFavorite.TabIndex = 11;
            this.buttonFavorite.UseVisualStyleBackColor = true;
            this.buttonFavorite.Click += new System.EventHandler(this.buttonFavorite_Click);
            // 
            // checkBoxFav
            // 
            this.checkBoxFav.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFav.AutoSize = true;
            this.checkBoxFav.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFav.Image")));
            this.checkBoxFav.Location = new System.Drawing.Point(409, 22);
            this.checkBoxFav.Name = "checkBoxFav";
            this.checkBoxFav.Size = new System.Drawing.Size(71, 38);
            this.checkBoxFav.TabIndex = 13;
            this.checkBoxFav.Text = "checkBox1";
            this.checkBoxFav.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ePubIntegrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBookPath;
        private System.Windows.Forms.Button buttonBookPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChapters;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxFav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBookmark;
        private System.Windows.Forms.Button buttonFavorite;
        private System.Windows.Forms.CheckBox checkBoxFav;
    }
}