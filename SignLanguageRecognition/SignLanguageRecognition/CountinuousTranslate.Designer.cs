namespace SignLanguageRecognition
{
    partial class CountinuousTranslate
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
            System.Environment.Exit(0);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountinuousTranslate));
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StartListeningBtn = new System.Windows.Forms.Button();
            this.StopListeningBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.informationBox = new System.Windows.Forms.GroupBox();
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
            this.StatusGif = new System.Windows.Forms.PictureBox();
            this.TranslationLabel = new System.Windows.Forms.Label();
            this.informationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusGif)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(29, 458);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "Back to Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(189, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "Continuous Translation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartListeningBtn
            // 
            this.StartListeningBtn.BackColor = System.Drawing.Color.Transparent;
            this.StartListeningBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartListeningBtn.BackgroundImage")));
            this.StartListeningBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartListeningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartListeningBtn.ForeColor = System.Drawing.Color.Transparent;
            this.StartListeningBtn.Location = new System.Drawing.Point(459, 436);
            this.StartListeningBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartListeningBtn.Name = "StartListeningBtn";
            this.StartListeningBtn.Size = new System.Drawing.Size(67, 62);
            this.StartListeningBtn.TabIndex = 22;
            this.StartListeningBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StartListeningBtn.UseVisualStyleBackColor = false;
            this.StartListeningBtn.Click += new System.EventHandler(this.StartListeningBtn_Click);
            // 
            // StopListeningBtn
            // 
            this.StopListeningBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopListeningBtn.BackgroundImage = global::SignLanguageRecognition.Properties.Resources.Stop_icon21;
            this.StopListeningBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopListeningBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopListeningBtn.ForeColor = System.Drawing.Color.Transparent;
            this.StopListeningBtn.Location = new System.Drawing.Point(613, 436);
            this.StopListeningBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StopListeningBtn.Name = "StopListeningBtn";
            this.StopListeningBtn.Size = new System.Drawing.Size(67, 62);
            this.StopListeningBtn.TabIndex = 23;
            this.StopListeningBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.StopListeningBtn.UseVisualStyleBackColor = false;
            this.StopListeningBtn.Click += new System.EventHandler(this.StopListeningBtn_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Salmon;
            this.output.Location = new System.Drawing.Point(412, 140);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Name = "output";
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.output.Size = new System.Drawing.Size(303, 180);
            this.output.TabIndex = 24;
            this.output.Text = "";
            // 
            // informationBox
            // 
            this.informationBox.BackColor = System.Drawing.Color.Transparent;
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
            this.informationBox.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.informationBox.Location = new System.Drawing.Point(16, 122);
            this.informationBox.Margin = new System.Windows.Forms.Padding(4);
            this.informationBox.Name = "informationBox";
            this.informationBox.Padding = new System.Windows.Forms.Padding(4);
            this.informationBox.Size = new System.Drawing.Size(311, 230);
            this.informationBox.TabIndex = 25;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Coordinates Information";
            // 
            // OutputData5
            // 
            this.OutputData5.AutoSize = true;
            this.OutputData5.BackColor = System.Drawing.Color.Transparent;
            this.OutputData5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData5.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData5.Location = new System.Drawing.Point(116, 172);
            this.OutputData5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData5.Name = "OutputData5";
            this.OutputData5.Size = new System.Drawing.Size(66, 28);
            this.OutputData5.TabIndex = 14;
            this.OutputData5.Text = "(0,0,0)";
            // 
            // OutputData4
            // 
            this.OutputData4.AutoSize = true;
            this.OutputData4.BackColor = System.Drawing.Color.Transparent;
            this.OutputData4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData4.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData4.Location = new System.Drawing.Point(116, 145);
            this.OutputData4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData4.Name = "OutputData4";
            this.OutputData4.Size = new System.Drawing.Size(66, 28);
            this.OutputData4.TabIndex = 13;
            this.OutputData4.Text = "(0,0,0)";
            // 
            // OutputData3
            // 
            this.OutputData3.AutoSize = true;
            this.OutputData3.BackColor = System.Drawing.Color.Transparent;
            this.OutputData3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData3.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData3.Location = new System.Drawing.Point(116, 118);
            this.OutputData3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData3.Name = "OutputData3";
            this.OutputData3.Size = new System.Drawing.Size(66, 28);
            this.OutputData3.TabIndex = 12;
            this.OutputData3.Text = "(0,0,0)";
            // 
            // OutputData2
            // 
            this.OutputData2.AutoSize = true;
            this.OutputData2.BackColor = System.Drawing.Color.Transparent;
            this.OutputData2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData2.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData2.Location = new System.Drawing.Point(116, 91);
            this.OutputData2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData2.Name = "OutputData2";
            this.OutputData2.Size = new System.Drawing.Size(66, 28);
            this.OutputData2.TabIndex = 11;
            this.OutputData2.Text = "(0,0,0)";
            // 
            // OutputData1
            // 
            this.OutputData1.AutoSize = true;
            this.OutputData1.BackColor = System.Drawing.Color.Transparent;
            this.OutputData1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputData1.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputData1.Location = new System.Drawing.Point(116, 64);
            this.OutputData1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputData1.Name = "OutputData1";
            this.OutputData1.Size = new System.Drawing.Size(66, 28);
            this.OutputData1.TabIndex = 10;
            this.OutputData1.Text = "(0,0,0)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pinky:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ring:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(8, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Middle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thumb:";
            // 
            // StatusGif
            // 
            this.StatusGif.BackColor = System.Drawing.Color.Transparent;
            this.StatusGif.Enabled = false;
            this.StatusGif.Image = global::SignLanguageRecognition.Properties.Resources.Loading11;
            this.StatusGif.Location = new System.Drawing.Point(609, 340);
            this.StatusGif.Margin = new System.Windows.Forms.Padding(4);
            this.StatusGif.Name = "StatusGif";
            this.StatusGif.Size = new System.Drawing.Size(71, 59);
            this.StatusGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusGif.TabIndex = 26;
            this.StatusGif.TabStop = false;
            // 
            // TranslationLabel
            // 
            this.TranslationLabel.AutoSize = true;
            this.TranslationLabel.BackColor = System.Drawing.Color.Transparent;
            this.TranslationLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslationLabel.ForeColor = System.Drawing.Color.Salmon;
            this.TranslationLabel.Location = new System.Drawing.Point(407, 358);
            this.TranslationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TranslationLabel.Name = "TranslationLabel";
            this.TranslationLabel.Size = new System.Drawing.Size(178, 28);
            this.TranslationLabel.TabIndex = 27;
            this.TranslationLabel.Text = "Translation Status:";
            // 
            // CountinuousTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignLanguageRecognition.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(759, 534);
            this.Controls.Add(this.TranslationLabel);
            this.Controls.Add(this.StatusGif);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.output);
            this.Controls.Add(this.StopListeningBtn);
            this.Controls.Add(this.StartListeningBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountinuousTranslate";
            this.Text = "Sign Recognition";
            this.Load += new System.EventHandler(this.CountinuousTranslate_Load);
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartListeningBtn;
        private System.Windows.Forms.Button StopListeningBtn;
        private System.Windows.Forms.RichTextBox output;
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
        private System.Windows.Forms.PictureBox StatusGif;
        private System.Windows.Forms.Label TranslationLabel;
    }
}