namespace Forms_App_2
{
    partial class BustripForm
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
            this.seatsBox = new System.Windows.Forms.TextBox();
            this.fromDateBox = new System.Windows.Forms.TextBox();
            this.toDateBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lägg till resa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seatsBox
            // 
            this.seatsBox.Location = new System.Drawing.Point(159, 195);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(168, 22);
            this.seatsBox.TabIndex = 5;
            this.seatsBox.Text = "20";
            // 
            // fromDateBox
            // 
            this.fromDateBox.Location = new System.Drawing.Point(159, 139);
            this.fromDateBox.Name = "fromDateBox";
            this.fromDateBox.Size = new System.Drawing.Size(168, 22);
            this.fromDateBox.TabIndex = 3;
            this.fromDateBox.Text = "2016-07-01 08:25:00";
            // 
            // toDateBox
            // 
            this.toDateBox.Location = new System.Drawing.Point(159, 167);
            this.toDateBox.Name = "toDateBox";
            this.toDateBox.Size = new System.Drawing.Size(168, 22);
            this.toDateBox.TabIndex = 4;
            this.toDateBox.Text = "2016-07-01 08:25:00";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(159, 223);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(168, 22);
            this.priceBox.TabIndex = 6;
            this.priceBox.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Antal platser:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Avresetid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ankomsttid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Från:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Till:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pris:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(436, 59);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lägg till bussresa";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(159, 405);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 17);
            this.test.TabIndex = 15;
            // 
            // fromBox
            // 
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(159, 83);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(168, 24);
            this.fromBox.TabIndex = 1;
            this.fromBox.SelectedIndexChanged += new System.EventHandler(this.fromBox_SelectedIndexChanged);
            // 
            // toBox
            // 
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(159, 111);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(168, 24);
            this.toBox.TabIndex = 2;
            this.toBox.SelectedIndexChanged += new System.EventHandler(this.toBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tillbaka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BustripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.toDateBox);
            this.Controls.Add(this.fromDateBox);
            this.Controls.Add(this.seatsBox);
            this.Controls.Add(this.button1);
            this.Name = "BustripForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox seatsBox;
        private System.Windows.Forms.TextBox fromDateBox;
        private System.Windows.Forms.TextBox toDateBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.Button button2;
    }
}

