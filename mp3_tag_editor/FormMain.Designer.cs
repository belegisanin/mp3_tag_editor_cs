namespace mp3_tag_editor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button_UploadFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Genres = new System.Windows.Forms.TextBox();
            this.textBox_Artists = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_TrackNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_Year = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Album = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Performers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Artwork = new System.Windows.Forms.PictureBox();
            this.button_ChangeArtwork = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TrackNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Artwork)).BeginInit();
            this.SuspendLayout();
            // 
            // button_UploadFile
            // 
            this.button_UploadFile.Location = new System.Drawing.Point(12, 12);
            this.button_UploadFile.Name = "button_UploadFile";
            this.button_UploadFile.Size = new System.Drawing.Size(348, 29);
            this.button_UploadFile.TabIndex = 0;
            this.button_UploadFile.Text = "Import File";
            this.button_UploadFile.UseVisualStyleBackColor = true;
            this.button_UploadFile.Click += new System.EventHandler(this.button_UploadFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Genres);
            this.groupBox1.Controls.Add(this.textBox_Artists);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numeric_TrackNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Comment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeric_Year);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Album);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Performers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tags";
            // 
            // textBox_Genres
            // 
            this.textBox_Genres.Enabled = false;
            this.textBox_Genres.Location = new System.Drawing.Point(119, 321);
            this.textBox_Genres.Name = "textBox_Genres";
            this.textBox_Genres.Size = new System.Drawing.Size(189, 20);
            this.textBox_Genres.TabIndex = 16;
            // 
            // textBox_Artists
            // 
            this.textBox_Artists.Enabled = false;
            this.textBox_Artists.Location = new System.Drawing.Point(119, 80);
            this.textBox_Artists.MaxLength = 256;
            this.textBox_Artists.Name = "textBox_Artists";
            this.textBox_Artists.Size = new System.Drawing.Size(189, 20);
            this.textBox_Artists.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Album Artists:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genres:";
            // 
            // numeric_TrackNo
            // 
            this.numeric_TrackNo.Enabled = false;
            this.numeric_TrackNo.Location = new System.Drawing.Point(120, 295);
            this.numeric_TrackNo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeric_TrackNo.Name = "numeric_TrackNo";
            this.numeric_TrackNo.Size = new System.Drawing.Size(75, 20);
            this.numeric_TrackNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Track Number:";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Enabled = false;
            this.textBox_Comment.Location = new System.Drawing.Point(22, 191);
            this.textBox_Comment.MaxLength = 30;
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(287, 75);
            this.textBox_Comment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Comment:";
            // 
            // numeric_Year
            // 
            this.numeric_Year.Enabled = false;
            this.numeric_Year.Location = new System.Drawing.Point(119, 133);
            this.numeric_Year.Maximum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numeric_Year.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.numeric_Year.Name = "numeric_Year";
            this.numeric_Year.Size = new System.Drawing.Size(120, 20);
            this.numeric_Year.TabIndex = 7;
            this.numeric_Year.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // textBox_Album
            // 
            this.textBox_Album.Enabled = false;
            this.textBox_Album.Location = new System.Drawing.Point(119, 106);
            this.textBox_Album.MaxLength = 256;
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(189, 20);
            this.textBox_Album.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album:";
            // 
            // textBox_Performers
            // 
            this.textBox_Performers.Enabled = false;
            this.textBox_Performers.Location = new System.Drawing.Point(120, 54);
            this.textBox_Performers.MaxLength = 256;
            this.textBox_Performers.Name = "textBox_Performers";
            this.textBox_Performers.Size = new System.Drawing.Size(189, 20);
            this.textBox_Performers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Performers:";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Enabled = false;
            this.textBox_Title.Location = new System.Drawing.Point(120, 28);
            this.textBox_Title.MaxLength = 256;
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(189, 20);
            this.textBox_Title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // pictureBox_Artwork
            // 
            this.pictureBox_Artwork.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox_Artwork.Location = new System.Drawing.Point(384, 16);
            this.pictureBox_Artwork.Name = "pictureBox_Artwork";
            this.pictureBox_Artwork.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_Artwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Artwork.TabIndex = 2;
            this.pictureBox_Artwork.TabStop = false;
            // 
            // button_ChangeArtwork
            // 
            this.button_ChangeArtwork.Location = new System.Drawing.Point(384, 274);
            this.button_ChangeArtwork.Name = "button_ChangeArtwork";
            this.button_ChangeArtwork.Size = new System.Drawing.Size(250, 25);
            this.button_ChangeArtwork.TabIndex = 3;
            this.button_ChangeArtwork.Text = "Change Artwork";
            this.button_ChangeArtwork.UseVisualStyleBackColor = true;
            this.button_ChangeArtwork.Click += new System.EventHandler(this.button_ChangeArtwork_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Location = new System.Drawing.Point(384, 346);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(250, 23);
            this.button_SaveFile.TabIndex = 4;
            this.button_SaveFile.Text = "Save File";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(384, 375);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(250, 23);
            this.button_Help.TabIndex = 5;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(384, 404);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(250, 23);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 441);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.button_ChangeArtwork);
            this.Controls.Add(this.pictureBox_Artwork);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_UploadFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "MP3 Tag Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TrackNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Artwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_UploadFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Album;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Performers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_TrackNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_Artwork;
        private System.Windows.Forms.Button button_ChangeArtwork;
        private System.Windows.Forms.TextBox textBox_Artists;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Genres;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_Exit;
    }
}

