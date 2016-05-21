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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //    System.Environment.Exit(0);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.informationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BackToMenuBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackToMenuBtn.Location = new System.Drawing.Point(22, 322);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(117, 32);
            this.BackToMenuBtn.TabIndex = 20;
            this.BackToMenuBtn.Text = "Back to Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = true;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Hadassah", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(106, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Continuous Translation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Salmon;
            this.output.Location = new System.Drawing.Point(291, 114);
            this.output.Name = "output";
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.output.Size = new System.Drawing.Size(228, 147);
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
            this.informationBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.informationBox.Location = new System.Drawing.Point(12, 99);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(233, 187);
            this.informationBox.TabIndex = 25;
            this.informationBox.TabStop = false;
            this.informationBox.Text = "Velocity Information:";
            this.informationBox.Enter += new System.EventHandler(this.informationBox_Enter);
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
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.clearBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.clearBtn.Location = new System.Drawing.Point(346, 322);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(117, 32);
            this.clearBtn.TabIndex = 26;
            this.clearBtn.Text = "Clear Text";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // CountinuousTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignLanguageRecognition.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(558, 379);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackToMenuBtn);
            this.Name = "CountinuousTranslate";
            this.Text = "Continouos Translation";
            this.Load += new System.EventHandler(this.CountinuousTranslate_Load);
            this.informationBox.ResumeLayout(false);
            this.informationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackToMenuBtn;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button clearBtn;
    }
}