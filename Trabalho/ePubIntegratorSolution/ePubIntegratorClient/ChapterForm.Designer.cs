namespace ePubIntegratorClient
{
    partial class ChapterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChapterForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonGoBmrk = new System.Windows.Forms.Button();
            this.radioButtonBmrk = new System.Windows.Forms.RadioButton();
            this.radioButtonFav = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.checkBoxBkmrk = new System.Windows.Forms.CheckBox();
            this.checkBoxFav = new System.Windows.Forms.CheckBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(782, 426);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonGoBmrk);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonBmrk);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonFav);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonAll);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxBkmrk);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxFav);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox);
            this.splitContainer2.Size = new System.Drawing.Size(198, 426);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 1;
            // 
            // buttonGoBmrk
            // 
            this.buttonGoBmrk.Location = new System.Drawing.Point(95, 14);
            this.buttonGoBmrk.Name = "buttonGoBmrk";
            this.buttonGoBmrk.Size = new System.Drawing.Size(95, 23);
            this.buttonGoBmrk.TabIndex = 23;
            this.buttonGoBmrk.Text = "Go to bookmark";
            this.buttonGoBmrk.UseVisualStyleBackColor = true;
            this.buttonGoBmrk.Click += new System.EventHandler(this.buttonGoBmrk_Click);
            // 
            // radioButtonBmrk
            // 
            this.radioButtonBmrk.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonBmrk.AutoSize = true;
            this.radioButtonBmrk.Location = new System.Drawing.Point(113, 50);
            this.radioButtonBmrk.Name = "radioButtonBmrk";
            this.radioButtonBmrk.Size = new System.Drawing.Size(77, 23);
            this.radioButtonBmrk.TabIndex = 22;
            this.radioButtonBmrk.Text = "Bookmarked";
            this.radioButtonBmrk.UseVisualStyleBackColor = true;
            this.radioButtonBmrk.CheckedChanged += new System.EventHandler(this.radioButtonBmrk_CheckedChanged);
            // 
            // radioButtonFav
            // 
            this.radioButtonFav.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFav.AutoSize = true;
            this.radioButtonFav.Location = new System.Drawing.Point(41, 50);
            this.radioButtonFav.Name = "radioButtonFav";
            this.radioButtonFav.Size = new System.Drawing.Size(66, 23);
            this.radioButtonFav.TabIndex = 21;
            this.radioButtonFav.Text = "Favourites";
            this.radioButtonFav.UseVisualStyleBackColor = true;
            this.radioButtonFav.CheckedChanged += new System.EventHandler(this.radioButtonFav_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(7, 50);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(28, 23);
            this.radioButtonAll.TabIndex = 20;
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
            this.checkBoxBkmrk.Location = new System.Drawing.Point(51, 6);
            this.checkBoxBkmrk.Name = "checkBoxBkmrk";
            this.checkBoxBkmrk.Size = new System.Drawing.Size(38, 38);
            this.checkBoxBkmrk.TabIndex = 19;
            this.checkBoxBkmrk.UseVisualStyleBackColor = true;
            this.checkBoxBkmrk.Click += new System.EventHandler(this.checkBoxBkmrk_Click);
            // 
            // checkBoxFav
            // 
            this.checkBoxFav.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFav.AutoSize = true;
            this.checkBoxFav.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxFav.Image")));
            this.checkBoxFav.Location = new System.Drawing.Point(7, 6);
            this.checkBoxFav.Name = "checkBoxFav";
            this.checkBoxFav.Size = new System.Drawing.Size(38, 38);
            this.checkBoxFav.TabIndex = 18;
            this.checkBoxFav.UseVisualStyleBackColor = true;
            this.checkBoxFav.Click += new System.EventHandler(this.checkBoxFav_Click);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(198, 342);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(580, 426);
            this.webBrowser1.TabIndex = 0;
            // 
            // ChapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChapterForm";
            this.Text = "ChapterForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonGoBmrk;
        private System.Windows.Forms.RadioButton radioButtonBmrk;
        private System.Windows.Forms.RadioButton radioButtonFav;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.CheckBox checkBoxBkmrk;
        private System.Windows.Forms.CheckBox checkBoxFav;
    }
}