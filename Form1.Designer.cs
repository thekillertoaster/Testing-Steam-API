namespace TestingSteamAPIFinal
{
    partial class Form1
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
            this.steamapikey = new System.Windows.Forms.TextBox();
            this.steamid64 = new System.Windows.Forms.TextBox();
            this.RawJSONTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.urllabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // steamapikey
            // 
            this.steamapikey.Location = new System.Drawing.Point(12, 12);
            this.steamapikey.Name = "steamapikey";
            this.steamapikey.Size = new System.Drawing.Size(656, 20);
            this.steamapikey.TabIndex = 0;
            this.steamapikey.Text = "Steam API Key";
            // 
            // steamid64
            // 
            this.steamid64.Location = new System.Drawing.Point(12, 38);
            this.steamid64.Name = "steamid64";
            this.steamid64.Size = new System.Drawing.Size(656, 20);
            this.steamid64.TabIndex = 1;
            this.steamid64.Text = "SteamID64";
            this.steamid64.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RawJSONTextBox
            // 
            this.RawJSONTextBox.Location = new System.Drawing.Point(12, 116);
            this.RawJSONTextBox.Name = "RawJSONTextBox";
            this.RawJSONTextBox.Size = new System.Drawing.Size(656, 125);
            this.RawJSONTextBox.TabIndex = 2;
            this.RawJSONTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raw JSON";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernamelabel.Location = new System.Drawing.Point(7, 260);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(108, 25);
            this.usernamelabel.TabIndex = 4;
            this.usernamelabel.Text = "Username:";
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchbutton.Location = new System.Drawing.Point(12, 64);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(656, 31);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // urllabel
            // 
            this.urllabel.AutoSize = true;
            this.urllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.urllabel.Location = new System.Drawing.Point(12, 247);
            this.urllabel.Name = "urllabel";
            this.urllabel.Size = new System.Drawing.Size(21, 13);
            this.urllabel.TabIndex = 6;
            this.urllabel.Text = "url:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(674, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.namelabel.Location = new System.Drawing.Point(7, 285);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(70, 25);
            this.namelabel.TabIndex = 8;
            this.namelabel.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 452);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.urllabel);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RawJSONTextBox);
            this.Controls.Add(this.steamid64);
            this.Controls.Add(this.steamapikey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox steamapikey;
        private System.Windows.Forms.TextBox steamid64;
        private System.Windows.Forms.RichTextBox RawJSONTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label urllabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namelabel;
    }
}

