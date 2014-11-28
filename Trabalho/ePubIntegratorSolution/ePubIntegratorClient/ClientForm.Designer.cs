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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookPath = new System.Windows.Forms.TextBox();
            this.buttonBookPath = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.buttonStats.Location = new System.Drawing.Point(635, 12);
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
            this.listBooks.Size = new System.Drawing.Size(187, 225);
            this.listBooks.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxBookPath);
            this.panel1.Controls.Add(this.buttonBookPath);
            this.panel1.Controls.Add(this.listBooks);
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 286);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(199, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 267);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.textBoxBookPath.Size = new System.Drawing.Size(151, 20);
            this.textBoxBookPath.TabIndex = 8;
            this.textBoxBookPath.Text = "C:\\Users\\Go0rum\\Documents\\";
            // 
            // buttonBookPath
            // 
            this.buttonBookPath.Enabled = false;
            this.buttonBookPath.Location = new System.Drawing.Point(163, 25);
            this.buttonBookPath.Name = "buttonBookPath";
            this.buttonBookPath.Size = new System.Drawing.Size(30, 20);
            this.buttonBookPath.TabIndex = 7;
            this.buttonBookPath.Text = "...";
            this.buttonBookPath.UseVisualStyleBackColor = true;
            this.buttonBookPath.Click += new System.EventHandler(this.buttonBookPath_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ePubIntegrator";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}