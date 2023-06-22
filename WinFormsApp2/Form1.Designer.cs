namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameText = new TextBox();
            emailText = new TextBox();
            contactText = new TextBox();
            button1 = new Button();
            label4 = new Label();
            findmailText = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 35);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 84);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "email";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 134);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "contact";
            label3.Click += label3_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(160, 27);
            nameText.Name = "nameText";
            nameText.Size = new Size(136, 23);
            nameText.TabIndex = 3;
            nameText.TextChanged += nameText_TextChanged;
            // 
            // emailText
            // 
            emailText.Location = new Point(160, 76);
            emailText.Name = "emailText";
            emailText.Size = new Size(136, 23);
            emailText.TabIndex = 4;
            // 
            // contactText
            // 
            contactText.Location = new Point(160, 126);
            contactText.Name = "contactText";
            contactText.Size = new Size(136, 23);
            contactText.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(221, 170);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 28);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "Enter Email";
            // 
            // findmailText
            // 
            findmailText.Location = new Point(586, 20);
            findmailText.Name = "findmailText";
            findmailText.Size = new Size(165, 23);
            findmailText.TabIndex = 8;
            findmailText.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(676, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "find";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(findmailText);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(contactText);
            Controls.Add(emailText);
            Controls.Add(nameText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameText;
        private TextBox emailText;
        private TextBox contactText;
        private Button button1;
        private Label label4;
        private TextBox findmailText;
        private Button button2;
    }
}