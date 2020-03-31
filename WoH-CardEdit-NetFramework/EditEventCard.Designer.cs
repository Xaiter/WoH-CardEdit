namespace WoH_CardEdit_NetFramework
{
    partial class EditEventCard
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.about = new System.Windows.Forms.TextBox();
            this.eventTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.isBigImage = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optionCount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eventLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.eventOption3 = new WoH_CardEdit_NetFramework.EventOptionUserControl();
            this.eventOption2 = new WoH_CardEdit_NetFramework.EventOptionUserControl();
            this.eventOption1 = new WoH_CardEdit_NetFramework.EventOptionUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Title:";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "Tiny text explaining the event, shown in main menu you hover over it. (Keep it sh" +
    "ort!)";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "About:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.about, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eventTitle, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // about
            // 
            this.about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.about.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.about.Location = new System.Drawing.Point(83, 41);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(194, 23);
            this.about.TabIndex = 1;
            this.about.Text = "Brief description for glossary.";
            // 
            // eventTitle
            // 
            this.eventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventTitle.Location = new System.Drawing.Point(83, 6);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(194, 23);
            this.eventTitle.TabIndex = 1;
            this.eventTitle.Text = "Card Title Shown To Player";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.contact, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.author, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 70);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // contact
            // 
            this.contact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contact.Location = new System.Drawing.Point(83, 41);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(194, 23);
            this.contact.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author:";
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.author.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.author.Location = new System.Drawing.Point(83, 6);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(194, 23);
            this.author.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Name && Description";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(307, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author && Contact Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox3.Size = new System.Drawing.Size(774, 437);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Details";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.eventOption3);
            this.panel1.Controls.Add(this.eventOption2);
            this.panel1.Controls.Add(this.eventOption1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 399);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.imagePath);
            this.groupBox4.Controls.Add(this.isBigImage);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.optionCount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.eventLocation);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.eventText);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 175);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Essentials";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(466, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "(Leave blank for generic current location image)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Image Path:";
            // 
            // imagePath
            // 
            this.imagePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.imagePath.Location = new System.Drawing.Point(82, 110);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(378, 23);
            this.imagePath.TabIndex = 15;
            // 
            // isBigImage
            // 
            this.isBigImage.AutoSize = true;
            this.isBigImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.isBigImage.Location = new System.Drawing.Point(82, 139);
            this.isBigImage.Name = "isBigImage";
            this.isBigImage.Size = new System.Drawing.Size(273, 19);
            this.isBigImage.TabIndex = 14;
            this.isBigImage.Text = "\"Big\" Image (See instructions.txt for details)";
            this.isBigImage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(605, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Option Count:";
            // 
            // optionCount
            // 
            this.optionCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.optionCount.FormattingEnabled = true;
            this.optionCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.optionCount.Location = new System.Drawing.Point(608, 60);
            this.optionCount.Name = "optionCount";
            this.optionCount.Size = new System.Drawing.Size(104, 23);
            this.optionCount.TabIndex = 12;
            this.optionCount.SelectedIndexChanged += new System.EventHandler(this.OnOptionCountChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(495, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Location:";
            // 
            // eventLocation
            // 
            this.eventLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.eventLocation.FormattingEnabled = true;
            this.eventLocation.Location = new System.Drawing.Point(498, 60);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(104, 23);
            this.eventLocation.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Event Text:";
            // 
            // eventText
            // 
            this.eventText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eventText.Location = new System.Drawing.Point(7, 44);
            this.eventText.Multiline = true;
            this.eventText.Name = "eventText";
            this.eventText.Size = new System.Drawing.Size(454, 60);
            this.eventText.TabIndex = 11;
            this.eventText.Text = "This is the text that will be shown on the game screen when this card is drawn.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSaveClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnLoadClicked);
            // 
            // eventOption3
            // 
            this.eventOption3.AutoSize = true;
            this.eventOption3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventOption3.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventOption3.Location = new System.Drawing.Point(0, 765);
            this.eventOption3.Name = "eventOption3";
            this.eventOption3.OptionGroupBoxTitle = "Option #3";
            this.eventOption3.Size = new System.Drawing.Size(747, 295);
            this.eventOption3.TabIndex = 16;
            // 
            // eventOption2
            // 
            this.eventOption2.AutoSize = true;
            this.eventOption2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventOption2.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventOption2.Location = new System.Drawing.Point(0, 470);
            this.eventOption2.Name = "eventOption2";
            this.eventOption2.OptionGroupBoxTitle = "Option #2";
            this.eventOption2.Size = new System.Drawing.Size(747, 295);
            this.eventOption2.TabIndex = 15;
            // 
            // eventOption1
            // 
            this.eventOption1.AutoSize = true;
            this.eventOption1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eventOption1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventOption1.Location = new System.Drawing.Point(0, 175);
            this.eventOption1.Name = "eventOption1";
            this.eventOption1.OptionGroupBoxTitle = "Option #1";
            this.eventOption1.Size = new System.Drawing.Size(747, 295);
            this.eventOption1.TabIndex = 14;
            // 
            // EditEventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 10000);
            this.MinimumSize = new System.Drawing.Size(790, 600);
            this.Name = "EditEventCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "WoH Event Card Editor (0.2003.31.1)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.TextBox eventTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private EventOptionUserControl eventOption3;
        private EventOptionUserControl eventOption2;
        private EventOptionUserControl eventOption1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox optionCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox eventLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.CheckBox isBigImage;
    }
}

