namespace Forms_App_1
{
    partial class SokForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.toBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.infobutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(102, 116);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(208, 20);
            this.toBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(102, 90);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(208, 20);
            this.fromBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Från";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(30, 224);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(0, 13);
            this.info1.TabIndex = 6;
            // 
            // infobutton1
            // 
            this.infobutton1.Location = new System.Drawing.Point(268, 220);
            this.infobutton1.Name = "infobutton1";
            this.infobutton1.Size = new System.Drawing.Size(81, 20);
            this.infobutton1.TabIndex = 7;
            this.infobutton1.Text = "Reseinfo";
            this.infobutton1.UseVisualStyleBackColor = true;
            this.infobutton1.Click += new System.EventHandler(this.infobutton1_Click);
            // 
            // SokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 527);
            this.Controls.Add(this.infobutton1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.button1);
            this.Name = "SokForm";
            this.Text = "sokform";
            this.Load += new System.EventHandler(this.SokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Button infobutton1;
    }
}