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
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBmrk = new System.Windows.Forms.RadioButton();
            this.radioButtonFav = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.checkBoxBkmrk = new System.Windows.Forms.CheckBox();
            this.checkBoxFav = new System.Windows.Forms.CheckBox();
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookPath = new System.Windows.Forms.TextBox();
            this.buttonBookPath = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.buttonFacebook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(6, 17);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(171, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "loading user name...";
            // 
            // buttonStats
            // 
            this.buttonStats.Image = ((System.Drawing.Image)(resources.GetObject("buttonStats.Image")));
            this.buttonStats.Location = new System.Drawing.Point(490, 8);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(40, 40);
            this.buttonStats.TabIndex = 5;
            this.buttonStats.UseVisualStyleBackColor = true;
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.Location = new System.Drawing.Point(6, 80);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(205, 225);
            this.listBooks.TabIndex = 6;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.listBooks_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonBmrk);
            this.panel1.Controls.Add(this.radioButtonFav);
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Controls.Add(this.checkBoxBkmrk);
            this.panel1.Controls.Add(this.checkBoxFav);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonChapters);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonRead);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBookPath);
            this.panel1.Controls.Add(this.buttonBookPath);
            this.panel1.Controls.Add(this.listBooks);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(2, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 315);
            this.panel1.TabIndex = 7;
            // 
            // radioButtonBmrk
            // 
            this.radioButtonBmrk.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonBmrk.AutoSize = true;
            this.radioButtonBmrk.Location = new System.Drawing.Point(134, 51);
            this.radioButtonBmrk.Name = "radioButtonBmrk";
            this.radioButtonBmrk.Size = new System.Drawing.Size(77, 23);
            this.radioButtonBmrk.TabIndex = 17;
            this.radioButtonBmrk.TabStop = true;
            this.radioButtonBmrk.Text = "Bookmarked";
            this.radioButtonBmrk.UseVisualStyleBackColor = true;
            this.radioButtonBmrk.CheckedChanged += new System.EventHandler(this.radioButtonBmrk_CheckedChanged);
            // 
            // radioButtonFav
            // 
            this.radioButtonFav.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFav.AutoSize = true;
            this.radioButtonFav.Location = new System.Drawing.Point(62, 51);
            this.radioButtonFav.Name = "radioButtonFav";
            this.radioButtonFav.Size = new System.Drawing.Size(66, 23);
            this.radioButtonFav.TabIndex = 16;
            this.radioButtonFav.TabStop = true;
            this.radioButtonFav.Text = "Favourites";
            this.radioButtonFav.UseVisualStyleBackColor = true;
            this.radioButtonFav.CheckedChanged += new System.EventHandler(this.radioButtonFav_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 51);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(28, 23);
            this.radioButtonAll.TabIndex = 15;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // checkBoxBkmrk
            // 
            this.checkBoxBkmrk.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBkmrk.AutoSize = true;
            this.checkBoxBkmrk.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxBkmrk.Image")));
            this.checkBoxBkmrk.Location = new System.Drawing.Point(375, 5);
            this.checkBoxBkmrk.Name = "checkBoxBkmrk";
            this.checkBoxBkmrk.Size = new System.Drawing.Size(38, 38);
            this.checkBoxBkmrk.TabIndex = 14;
            this.checkBoxBkmrk.UseVisualStyleBackColor = true;
            this.checkBoxBkmrk.CheckedChanged += new System.EventHandler(this.checkBoxBkmrk_CheckedChanged);
            // 
            // checkBoxFav
            // 
            this.checkBoxFav.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFav.AutoSize = true;
            this.checkBoxFav.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFav.Image")));
            this.checkBoxFav.Location = new System.Drawing.Point(331, 5);
            this.checkBoxFav.Name = "checkBoxFav";
            this.checkBoxFav.Size = new System.Drawing.Size(38, 38);
            this.checkBoxFav.TabIndex = 13;
            this.checkBoxFav.UseVisualStyleBackColor = true;
            this.checkBoxFav.CheckedChanged += new System.EventHandler(this.checkBoxFav_CheckedChanged);
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
            this.buttonChapters.Location = new System.Drawing.Point(283, 3);
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
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(235, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 254);
            this.panel2.TabIndex = 9;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(72, 96);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(10, 13);
            this.labelDesc.TabIndex = 14;
            this.labelDesc.Text = "-";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(55, 83);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(10, 13);
            this.labelSubject.TabIndex = 13;
            this.labelSubject.Text = "-";
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Location = new System.Drawing.Point(53, 31);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(10, 13);
            this.labelCreator.TabIndex = 12;
            this.labelCreator.Text = "-";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(67, 44);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(10, 13);
            this.labelLanguage.TabIndex = 8;
            this.labelLanguage.Text = "-";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(42, 57);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(10, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "-";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(62, 70);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(10, 13);
            this.labelPublisher.TabIndex = 10;
            this.labelPublisher.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Creator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(10, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publisher:";
            // 
            // buttonRead
            // 
            this.buttonRead.Image = ((System.Drawing.Image)(resources.GetObject("buttonRead.Image")));
            this.buttonRead.Location = new System.Drawing.Point(235, 3);
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
            this.textBoxBookPath.ReadOnly = true;
            this.textBoxBookPath.Size = new System.Drawing.Size(129, 20);
            this.textBoxBookPath.TabIndex = 8;
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(530, 311);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 222;
            this.lineShape1.X2 = 222;
            this.lineShape1.Y1 = 4;
            this.lineShape1.Y2 = 303;
            // 
            // buttonFacebook
            // 
            this.buttonFacebook.Image = ((System.Drawing.Image)(resources.GetObject("buttonFacebook.Image")));
            this.buttonFacebook.Location = new System.Drawing.Point(442, 8);
            this.buttonFacebook.Name = "buttonFacebook";
            this.buttonFacebook.Size = new System.Drawing.Size(42, 42);
            this.buttonFacebook.TabIndex = 19;
            this.buttonFacebook.UseVisualStyleBackColor = true;
            this.buttonFacebook.Click += new System.EventHandler(this.buttonFacebook_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 372);
            this.Controls.Add(this.buttonFacebook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.labelUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ePubIntegrator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.CheckBox checkBoxFav;
        private System.Windows.Forms.CheckBox checkBoxBkmrk;
        private System.Windows.Forms.RadioButton radioButtonBmrk;
        private System.Windows.Forms.RadioButton radioButtonFav;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button buttonFacebook;
    }
}