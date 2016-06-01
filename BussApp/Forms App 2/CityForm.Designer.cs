namespace Forms_App_2
{
    partial class CityForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.currencyBox = new System.Windows.Forms.TextBox();
            this.timezoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lägg till stad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Land:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Valuta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tidszon:";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(142, 192);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(168, 22);
            this.countryBox.TabIndex = 4;
            this.countryBox.Text = "Sverige";
            // 
            // currencyBox
            // 
            this.currencyBox.Location = new System.Drawing.Point(142, 164);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(168, 22);
            this.currencyBox.TabIndex = 3;
            this.currencyBox.Text = "SEK";
            // 
            // timezoneBox
            // 
            this.timezoneBox.Location = new System.Drawing.Point(142, 220);
            this.timezoneBox.Name = "timezoneBox";
            this.timezoneBox.Size = new System.Drawing.Size(168, 22);
            this.timezoneBox.TabIndex = 5;
            this.timezoneBox.Text = "GMT +1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Språk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Stad:";
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(142, 136);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(168, 22);
            this.languageBox.TabIndex = 2;
            this.languageBox.Text = "Svenska";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(142, 108);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(168, 22);
            this.cityBox.TabIndex = 1;
            this.cityBox.Text = "Helsingborg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 59);
            this.label6.TabIndex = 26;
            this.label6.Text = "Lägg till stad";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tillbaka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.currencyBox);
            this.Controls.Add(this.timezoneBox);
            this.Controls.Add(this.button1);
            this.Name = "CityForm";
            this.Text = "CityForm";
            this.Load += new System.EventHandler(this.CityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox currencyBox;
        private System.Windows.Forms.TextBox timezoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}