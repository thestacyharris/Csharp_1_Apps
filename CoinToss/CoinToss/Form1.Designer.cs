namespace CoinToss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tossNumTextBox = new System.Windows.Forms.TextBox();
            this.headsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.percentHeadsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.percentTailsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
            this.headsPictureBox.Location = new System.Drawing.Point(36, 30);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
            this.tailsPictureBox.Location = new System.Drawing.Point(36, 30);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(36, 226);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "TOSS";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(131, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Tosses:";
            // 
            // tossNumTextBox
            // 
            this.tossNumTextBox.Location = new System.Drawing.Point(138, 265);
            this.tossNumTextBox.Name = "tossNumTextBox";
            this.tossNumTextBox.Size = new System.Drawing.Size(68, 20);
            this.tossNumTextBox.TabIndex = 5;
            this.tossNumTextBox.Text = "0";
            // 
            // headsTextBox
            // 
            this.headsTextBox.Location = new System.Drawing.Point(138, 299);
            this.headsTextBox.Name = "headsTextBox";
            this.headsTextBox.Size = new System.Drawing.Size(68, 20);
            this.headsTextBox.TabIndex = 7;
            this.headsTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Heads:";
            // 
            // tailsTextBox
            // 
            this.tailsTextBox.Location = new System.Drawing.Point(138, 370);
            this.tailsTextBox.Name = "tailsTextBox";
            this.tailsTextBox.Size = new System.Drawing.Size(68, 20);
            this.tailsTextBox.TabIndex = 9;
            this.tailsTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Tails:";
            // 
            // percentHeadsTextBox
            // 
            this.percentHeadsTextBox.Location = new System.Drawing.Point(138, 335);
            this.percentHeadsTextBox.Name = "percentHeadsTextBox";
            this.percentHeadsTextBox.Size = new System.Drawing.Size(68, 20);
            this.percentHeadsTextBox.TabIndex = 11;
            this.percentHeadsTextBox.Text = "0.00%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Heads Percentage:";
            // 
            // percentTailsTextBox
            // 
            this.percentTailsTextBox.Location = new System.Drawing.Point(138, 405);
            this.percentTailsTextBox.Name = "percentTailsTextBox";
            this.percentTailsTextBox.Size = new System.Drawing.Size(68, 20);
            this.percentTailsTextBox.TabIndex = 13;
            this.percentTailsTextBox.Text = "0.00%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tails Percentage:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 442);
            this.Controls.Add(this.percentTailsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentHeadsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tailsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tossNumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tossNumTextBox;
        private System.Windows.Forms.TextBox headsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tailsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox percentHeadsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox percentTailsTextBox;
        private System.Windows.Forms.Label label5;
    }
}

