namespace SignLanguageRecognition
{
    partial class SignsDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignsDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SamplesList = new System.Windows.Forms.ListBox();
            this.CaptureFrameBtn = new System.Windows.Forms.Button();
            this.StartListeningBtn = new System.Windows.Forms.Button();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.DeleteSampleBtn = new System.Windows.Forms.Button();
            this.informationBox = new System.Windows.Forms.GroupBox();
            this.LettersCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OutputData5 = new System.Windows.Forms.Label();
            this.OutputData4 = new System.Windows.Forms.Label();
            this.OutputData3 = new System.Windows.Forms.Label();
            this.OutputData2 = new System.Windows.Forms.Label();
            this.OutputData1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.informationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(71, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Signs Database:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Hadassah", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(139, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sign Language Database";
            // 
            // SamplesList
            // 
            this.SamplesList.BackColor = System.Drawing.Color.LightGray;
            this.SamplesList.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplesList.ForeColor = System.Drawing.Color.Salmon;
            this.SamplesList.FormattingEnabled = true;
            this.SamplesList.ItemHeight = 24;
            this.SamplesList.Location = new System.Drawing.Point(76, 158);
            this.SamplesList.Name = "SamplesList";
            this.SamplesList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SamplesList.Size = new System.Drawing.Size(117, 196);
            this.SamplesList.TabIndex = 11;
            this.SamplesList.SelectedIndexChanged += new System.EventHandler(this.SamplesList_SelectedIndexChanged);
            this.SamplesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            // 
            // CaptureFrameBtn
            // 
            this.CaptureFrameBtn.BackColor = System.Drawing.Color.Transparent;
            this.CaptureFrameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CaptureFrameBtn.BackgroundImage")));
            this.CaptureFrameBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CaptureFrameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaptureFrameBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CaptureFrameBtn.Location = new System.Drawing.Point(406, 401);
            this.CaptureFrameBtn.Name = "CaptureFrameBtn";
            this.CaptureFrameBtn.Size = new System.Drawing.Size(50, 50);
            this.CaptureFrameBtn.TabIndex = 13;
            this.CaptureFrameBtn.UseVisualStyleBackColor = false;
            this.CaptureFrameBtn.Click += new System.EventHandler(this.CaptureFrameBtn_Click);
            this.CaptureFrameBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            // 
            // StartListeningBtn
            // 
            this.StartListeningBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartListeningBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartListeningBtn.BackgroundImage")));
            this.StartListeningBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartListeningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartListeningBtn.ForeColor = System.Drawing.Color.Transparent;
            this.StartListeningBtn.Location = new System.Drawing.Point(282, 401);
            this.StartListeningBtn.Name = "StartListeningBtn";
            this.StartListeningBtn.Size = new System.Drawing.Size(50, 50);
            this.StartListeningBtn.TabIndex = 14;
            this.StartListeningBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StartListeningBtn.UseVisualStyleBackColor = false;
            this.StartListeningBtn.Click += new System.EventHandler(this.StartListeningBtn_Click);
            this.StartListeningBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BackToMenuBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackToMenuBtn.Location = new System.Drawing.Point(76, 419);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(117, 32);
            this.BackToMenuBtn.TabIndex = 15;
            this.BackToMenuBtn.Text = "Back to Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            this.BackToMenuBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            // 
            // DeleteSampleBtn
            // 
            this.DeleteSampleBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSampleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteSampleBtn.BackgroundImage")));
            this.DeleteSampleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteSampleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSampleBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteSampleBtn.Location = new System.Drawing.Point(47, 335);
            this.DeleteSampleBtn.Name = "DeleteSampleBtn";
            this.DeleteSampleBtn.Size = new System.Drawing.Size(23, 24);
            this.DeleteSampleBtn.TabIndex = 16;
            this.DeleteSampleBtn.UseVisualStyleBackColor = false;
            this.DeleteSampleBtn.Click += new System.EventHandler(this.DeleteSampleBtn_Click);
            this.DeleteSampleBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            // 
            // informationBox
            // 
            this.informationBox.BackColor = System.Drawing.Color.Transparent;
            this.informationBox.Controls.Add(this.LettersCombo);
            this.informationBox.Controls.Add(this.label9);
            this.informationBox.Controls.Add(this.OutputData5);
            this.informationBox.Controls.Add(this.OutputData4);
            this.informationBox.Controls.Add(this.OutputData3);
            this.informationBox.Controls.Add(this.OutputData2);
            this.informationBox.Controls.Add(this.OutputData1);
            this.informationBox.Controls.Add(this.label7);
            this.informationBox.Controls.Add(this.label6);
            this.informationBox.Controls.Add(this.label5);
            this.informationBox.Controls.Add(this.label4);
            this.informationBox.Controls.Add(this.label3);
            this.informationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.informationBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.informationBox.Location = new System.Drawing.Point(282, 113);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(322, 282);
            this.informationBox.TabIndex = 17;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Distances information:";
            this.informationBox.Enter += new System.EventHandler(this.informationBox_Enter);
            // 
            // LettersCombo
            // 
            this.LettersCombo.FormattingEnabled = true;
            this.LettersCombo.Items.AddRange(new object[] {
            " ",
            "*",
            "א",
            "ב",
            "ג",
            "ד",
            "ה",
            "ו",
            "ז",
            "ח",
            "ט",
            "י",
            "כ",
            "ל",
            "מ",
            "נ",
            "ס",
            "ע",
            "פ",
            "צ",
            "ק",
            "ר",
            "ש",
            "ת"});
            this.LettersCombo.Location = new System.Drawing.Point(91, 216);
            this.LettersCombo.Name = "LettersCombo";
            this.LettersCombo.Size = new System.Drawing.Size(79, 32);
            this.LettersCombo.TabIndex = 19;
            this.LettersCombo.Text = "א";
            this.LettersCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureFrameBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(6, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Letter";
            // 
            // OutputData5
            // 
            this.OutputData5.AutoSize = true;
            this.OutputData5.BackColor = System.Drawing.Color.Transparent;
            this.OutputData5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData5.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData5.Location = new System.Drawing.Point(87, 140);
            this.OutputData5.Name = "OutputData5";
            this.OutputData5.Size = new System.Drawing.Size(51, 22);
            this.OutputData5.TabIndex = 14;
            this.OutputData5.Text = "(0,0,0)";
            // 
            // OutputData4
            // 
            this.OutputData4.AutoSize = true;
            this.OutputData4.BackColor = System.Drawing.Color.Transparent;
            this.OutputData4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData4.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData4.Location = new System.Drawing.Point(87, 118);
            this.OutputData4.Name = "OutputData4";
            this.OutputData4.Size = new System.Drawing.Size(51, 22);
            this.OutputData4.TabIndex = 13;
            this.OutputData4.Text = "(0,0,0)";
            // 
            // OutputData3
            // 
            this.OutputData3.AutoSize = true;
            this.OutputData3.BackColor = System.Drawing.Color.Transparent;
            this.OutputData3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData3.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData3.Location = new System.Drawing.Point(87, 96);
            this.OutputData3.Name = "OutputData3";
            this.OutputData3.Size = new System.Drawing.Size(51, 22);
            this.OutputData3.TabIndex = 12;
            this.OutputData3.Text = "(0,0,0)";
            // 
            // OutputData2
            // 
            this.OutputData2.AutoSize = true;
            this.OutputData2.BackColor = System.Drawing.Color.Transparent;
            this.OutputData2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData2.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData2.Location = new System.Drawing.Point(87, 74);
            this.OutputData2.Name = "OutputData2";
            this.OutputData2.Size = new System.Drawing.Size(51, 22);
            this.OutputData2.TabIndex = 11;
            this.OutputData2.Text = "(0,0,0)";
            // 
            // OutputData1
            // 
            this.OutputData1.AutoSize = true;
            this.OutputData1.BackColor = System.Drawing.Color.Transparent;
            this.OutputData1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData1.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData1.Location = new System.Drawing.Point(87, 52);
            this.OutputData1.Name = "OutputData1";
            this.OutputData1.Size = new System.Drawing.Size(51, 22);
            this.OutputData1.TabIndex = 10;
            this.OutputData1.Text = "(0,0,0)";
            this.OutputData1.Click += new System.EventHandler(this.OutputData1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pinky:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ring:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Middle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thumb:";
            // 
            // SignsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignLanguageRecognition.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(655, 463);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.DeleteSampleBtn);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.StartListeningBtn);
            this.Controls.Add(this.CaptureFrameBtn);
            this.Controls.Add(this.SamplesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignsDatabase";
            this.Text = "Sign Language Database";
            this.Load += new System.EventHandler(this.SignsDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SignsDatabase_KeyDown);
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ListBox SamplesList;
        private System.Windows.Forms.Button CaptureFrameBtn;
        private System.Windows.Forms.Button StartListeningBtn;
        private System.Windows.Forms.Button BackToMenuBtn;
        private System.Windows.Forms.Button DeleteSampleBtn;
        private System.Windows.Forms.GroupBox informationBox;
        private System.Windows.Forms.Label OutputData5;
        private System.Windows.Forms.Label OutputData4;
        private System.Windows.Forms.Label OutputData3;
        private System.Windows.Forms.Label OutputData2;
        private System.Windows.Forms.Label OutputData1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox LettersCombo;
    }
}