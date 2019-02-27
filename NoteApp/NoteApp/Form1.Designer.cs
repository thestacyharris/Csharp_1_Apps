namespace NoteApp
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
            this.clearButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msgTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(13, 23);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(118, 69);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(118, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(222, 23);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "READ";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message Title:";
            // 
            // msgTitleTextBox
            // 
            this.msgTitleTextBox.Location = new System.Drawing.Point(118, 104);
            this.msgTitleTextBox.Name = "msgTitleTextBox";
            this.msgTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.msgTitleTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(118, 139);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 20);
            this.messageTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox msgTitleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}

