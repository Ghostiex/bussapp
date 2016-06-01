namespace Forms_App_1
{
    partial class InfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.originText = new System.Windows.Forms.Label();
            this.destinationText = new System.Windows.Forms.Label();
            this.dateText1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableseatsText = new System.Windows.Forms.Label();
            this.dateText2 = new System.Windows.Forms.Label();
            this.valutaText = new System.Windows.Forms.Label();
            this.språkText = new System.Windows.Forms.Label();
            this.landText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bokaBtn = new System.Windows.Forms.Button();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.originDateLabel = new System.Windows.Forms.Label();
            this.destinationDateLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resinfo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // originText
            // 
            this.originText.AutoSize = true;
            this.originText.Location = new System.Drawing.Point(123, 119);
            this.originText.Name = "originText";
            this.originText.Size = new System.Drawing.Size(41, 17);
            this.originText.TabIndex = 2;
            this.originText.Text = "Från:";
            // 
            // destinationText
            // 
            this.destinationText.AutoSize = true;
            this.destinationText.Location = new System.Drawing.Point(134, 136);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(30, 17);
            this.destinationText.TabIndex = 3;
            this.destinationText.Text = "Till:";
            this.destinationText.Click += new System.EventHandler(this.destinationText_Click);
            // 
            // dateText1
            // 
            this.dateText1.AutoSize = true;
            this.dateText1.Location = new System.Drawing.Point(108, 153);
            this.dateText1.Name = "dateText1";
            this.dateText1.Size = new System.Drawing.Size(56, 17);
            this.dateText1.TabIndex = 4;
            this.dateText1.Text = "Avresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pris:";
            // 
            // availableseatsText
            // 
            this.availableseatsText.AutoSize = true;
            this.availableseatsText.Location = new System.Drawing.Point(62, 187);
            this.availableseatsText.Name = "availableseatsText";
            this.availableseatsText.Size = new System.Drawing.Size(102, 17);
            this.availableseatsText.TabIndex = 6;
            this.availableseatsText.Text = "Lediga platser:";
            // 
            // dateText2
            // 
            this.dateText2.AutoSize = true;
            this.dateText2.Location = new System.Drawing.Point(98, 170);
            this.dateText2.Name = "dateText2";
            this.dateText2.Size = new System.Drawing.Size(66, 17);
            this.dateText2.TabIndex = 5;
            this.dateText2.Text = "Ankomst:";
            // 
            // valutaText
            // 
            this.valutaText.AutoSize = true;
            this.valutaText.Location = new System.Drawing.Point(112, 395);
            this.valutaText.Name = "valutaText";
            this.valutaText.Size = new System.Drawing.Size(52, 17);
            this.valutaText.TabIndex = 10;
            this.valutaText.Text = "Valuta:";
            // 
            // språkText
            // 
            this.språkText.AutoSize = true;
            this.språkText.Location = new System.Drawing.Point(115, 378);
            this.språkText.Name = "språkText";
            this.språkText.Size = new System.Drawing.Size(49, 17);
            this.språkText.TabIndex = 9;
            this.språkText.Text = "Språk:";
            // 
            // landText
            // 
            this.landText.AutoSize = true;
            this.landText.Location = new System.Drawing.Point(120, 361);
            this.landText.Name = "landText";
            this.landText.Size = new System.Drawing.Size(44, 17);
            this.landText.TabIndex = 8;
            this.landText.Text = "Land:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 59);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destinationsinfo";
            // 
            // bokaBtn
            // 
            this.bokaBtn.Location = new System.Drawing.Point(350, 261);
            this.bokaBtn.Name = "bokaBtn";
            this.bokaBtn.Size = new System.Drawing.Size(93, 23);
            this.bokaBtn.TabIndex = 12;
            this.bokaBtn.Text = "Boka resa";
            this.bokaBtn.UseVisualStyleBackColor = true;
            this.bokaBtn.Click += new System.EventHandler(this.bokaBtn_Click);
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(170, 119);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(0, 17);
            this.originLabel.TabIndex = 13;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(170, 136);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(0, 17);
            this.destinationLabel.TabIndex = 14;
            // 
            // originDateLabel
            // 
            this.originDateLabel.AutoSize = true;
            this.originDateLabel.Location = new System.Drawing.Point(170, 153);
            this.originDateLabel.Name = "originDateLabel";
            this.originDateLabel.Size = new System.Drawing.Size(0, 17);
            this.originDateLabel.TabIndex = 15;
            // 
            // destinationDateLabel
            // 
            this.destinationDateLabel.AutoSize = true;
            this.destinationDateLabel.Location = new System.Drawing.Point(170, 170);
            this.destinationDateLabel.Name = "destinationDateLabel";
            this.destinationDateLabel.Size = new System.Drawing.Size(0, 17);
            this.destinationDateLabel.TabIndex = 16;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(170, 187);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(0, 17);
            this.availableLabel.TabIndex = 17;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(170, 204);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 17);
            this.priceLabel.TabIndex = 18;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(170, 361);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(0, 17);
            this.countryLabel.TabIndex = 19;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(170, 378);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(0, 17);
            this.languageLabel.TabIndex = 20;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Location = new System.Drawing.Point(170, 395);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(0, 17);
            this.currencyLabel.TabIndex = 21;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(65, 262);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(270, 22);
            this.emailBox.TabIndex = 22;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 537);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.destinationDateLabel);
            this.Controls.Add(this.originDateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.bokaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valutaText);
            this.Controls.Add(this.språkText);
            this.Controls.Add(this.landText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.availableseatsText);
            this.Controls.Add(this.dateText2);
            this.Controls.Add(this.dateText1);
            this.Controls.Add(this.destinationText);
            this.Controls.Add(this.originText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label originText;
        private System.Windows.Forms.Label destinationText;
        private System.Windows.Forms.Label dateText1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label availableseatsText;
        private System.Windows.Forms.Label dateText2;
        private System.Windows.Forms.Label valutaText;
        private System.Windows.Forms.Label språkText;
        private System.Windows.Forms.Label landText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bokaBtn;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label originDateLabel;
        private System.Windows.Forms.Label destinationDateLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox emailBox;
    }
}