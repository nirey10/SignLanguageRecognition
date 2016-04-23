namespace SignLanguageRecognition
{
    partial class MainMenu
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
           
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignDatabaseBtn = new System.Windows.Forms.Button();
            this.ContinuousTranslatingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SingleInstancesTranslatingBtn = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignDatabaseBtn
            // 
            this.SignDatabaseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.SignDatabaseBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.SignDatabaseBtn.Location = new System.Drawing.Point(150, 112);
            this.SignDatabaseBtn.Name = "SignDatabaseBtn";
            this.SignDatabaseBtn.Size = new System.Drawing.Size(190, 44);
            this.SignDatabaseBtn.TabIndex = 0;
            this.SignDatabaseBtn.Text = "Signs Database";
            this.SignDatabaseBtn.UseVisualStyleBackColor = true;
            this.SignDatabaseBtn.Click += new System.EventHandler(this.SignDatabaseBtn_Click);
            // 
            // ContinuousTranslatingBtn
            // 
            this.ContinuousTranslatingBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.ContinuousTranslatingBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.ContinuousTranslatingBtn.Location = new System.Drawing.Point(150, 263);
            this.ContinuousTranslatingBtn.Name = "ContinuousTranslatingBtn";
            this.ContinuousTranslatingBtn.Size = new System.Drawing.Size(190, 44);
            this.ContinuousTranslatingBtn.TabIndex = 1;
            this.ContinuousTranslatingBtn.Text = "Continuous Translating";
            this.ContinuousTranslatingBtn.UseVisualStyleBackColor = true;
            this.ContinuousTranslatingBtn.Click += new System.EventHandler(this.ContinuousTranslatingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Language Recognition";
            // 
            // SingleInstancesTranslatingBtn
            // 
            this.SingleInstancesTranslatingBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.SingleInstancesTranslatingBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.SingleInstancesTranslatingBtn.Location = new System.Drawing.Point(150, 189);
            this.SingleInstancesTranslatingBtn.Name = "SingleInstancesTranslatingBtn";
            this.SingleInstancesTranslatingBtn.Size = new System.Drawing.Size(190, 44);
            this.SingleInstancesTranslatingBtn.TabIndex = 3;
            this.SingleInstancesTranslatingBtn.Text = "Single Instances Translating";
            this.SingleInstancesTranslatingBtn.UseVisualStyleBackColor = true;
            this.SingleInstancesTranslatingBtn.Click += new System.EventHandler(this.SingleInstancesTranslatingBtn_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.AutoSize = true;
            this.ConnectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(12, 357);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(155, 25);
            this.ConnectionStatusLabel.TabIndex = 4;
            this.ConnectionStatusLabel.Text = "Connection Status:";
            // 
            // ConnectionLable
            // 
            this.ConnectionLable.AutoSize = true;
            this.ConnectionLable.BackColor = System.Drawing.Color.Transparent;
            this.ConnectionLable.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.ConnectionLable.ForeColor = System.Drawing.Color.Crimson;
            this.ConnectionLable.Location = new System.Drawing.Point(164, 357);
            this.ConnectionLable.Name = "ConnectionLable";
            this.ConnectionLable.Size = new System.Drawing.Size(182, 25);
            this.ConnectionLable.TabIndex = 5;
            this.ConnectionLable.Text = "Leap is Not Connected";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SignLanguageRecognition.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(487, 391);
            this.Controls.Add(this.ConnectionLable);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.SingleInstancesTranslatingBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContinuousTranslatingBtn);
            this.Controls.Add(this.SignDatabaseBtn);
            this.Name = "MainMenu";
            this.Text = "Sign Language Recognition";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignDatabaseBtn;
        private System.Windows.Forms.Button ContinuousTranslatingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SingleInstancesTranslatingBtn;
        private System.Windows.Forms.Label ConnectionLable;
        private System.Windows.Forms.Label ConnectionStatusLabel;
    }
}

