namespace Assignment2
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
            this.myNameLabel = new System.Windows.Forms.Label();
            this.quoteButton = new System.Windows.Forms.Button();
            this.funButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.myImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.myNameLabel.Location = new System.Drawing.Point(104, 9);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(141, 29);
            this.myNameLabel.TabIndex = 0;
            this.myNameLabel.Text = "Stacy Harris";
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(29, 334);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(123, 31);
            this.quoteButton.TabIndex = 1;
            this.quoteButton.Text = "My Favorite Quote";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // funButton
            // 
            this.funButton.Location = new System.Drawing.Point(202, 334);
            this.funButton.Name = "funButton";
            this.funButton.Size = new System.Drawing.Size(123, 31);
            this.funButton.TabIndex = 2;
            this.funButton.Text = "What I Do for Fun";
            this.funButton.UseVisualStyleBackColor = true;
            this.funButton.Click += new System.EventHandler(this.funButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(122, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 31);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close Program";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // myImagePictureBox
            // 
            this.myImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myImagePictureBox.Enabled = false;
            this.myImagePictureBox.Image = global::Assignment2.Properties.Resources._20181114_165257_IMG_0118;
            this.myImagePictureBox.Location = new System.Drawing.Point(66, 54);
            this.myImagePictureBox.Name = "myImagePictureBox";
            this.myImagePictureBox.Size = new System.Drawing.Size(219, 257);
            this.myImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myImagePictureBox.TabIndex = 4;
            this.myImagePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 445);
            this.Controls.Add(this.myImagePictureBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.funButton);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.myNameLabel);
            this.Name = "Form1";
            this.Text = "Assignment 2";
            ((System.ComponentModel.ISupportInitialize)(this.myImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Button funButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox myImagePictureBox;
    }
}

