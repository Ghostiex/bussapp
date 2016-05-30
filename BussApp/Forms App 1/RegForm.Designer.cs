namespace Forms_App_1
{
    partial class RegForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.personnrBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonnrBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Förnamn";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(139, 82);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(163, 20);
            this.firstnameBox.TabIndex = 1;
            this.firstnameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Registrera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Efternamn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Person nr";
            // 
            // personnrBox
            // 
            this.personnrBox.Location = new System.Drawing.Point(139, 135);
            this.personnrBox.Name = "personnrBox";
            this.personnrBox.Size = new System.Drawing.Size(163, 20);
            this.personnrBox.TabIndex = 3;
            this.personnrBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(139, 108);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(163, 20);
            this.lastnameBox.TabIndex = 2;
            this.lastnameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(139, 161);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(163, 20);
            this.addressBox.TabIndex = 4;
            this.addressBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(139, 187);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(163, 20);
            this.emailBox.TabIndex = 5;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // telefonnrBox
            // 
            this.telefonnrBox.Location = new System.Drawing.Point(139, 213);
            this.telefonnrBox.Name = "telefonnrBox";
            this.telefonnrBox.Size = new System.Drawing.Size(163, 20);
            this.telefonnrBox.TabIndex = 6;
            this.telefonnrBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon nr";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // RegForm
            // 
            this.ClientSize = new System.Drawing.Size(327, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.telefonnrBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.personnrBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personnrBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonnrBox;
        private System.Windows.Forms.Label label7;
    }
}