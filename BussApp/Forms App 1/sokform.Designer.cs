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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.toBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            this.infobutton1 = new System.Windows.Forms.Button();
            this.tillbakaBtn = new System.Windows.Forms.Button();
            this.bussappDataSet1 = new Forms_App_1.bussappDataSet1();
            this.bussappDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.outputText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bussappDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussappDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sök";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(136, 143);
            this.toBox.Margin = new System.Windows.Forms.Padding(4);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(276, 22);
            this.toBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(136, 111);
            this.fromBox.Margin = new System.Windows.Forms.Padding(4);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(276, 22);
            this.fromBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Från";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(40, 276);
            this.info1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(0, 17);
            this.info1.TabIndex = 6;
            // 
            // infobutton1
            // 
            this.infobutton1.Location = new System.Drawing.Point(342, 272);
            this.infobutton1.Margin = new System.Windows.Forms.Padding(4);
            this.infobutton1.Name = "infobutton1";
            this.infobutton1.Size = new System.Drawing.Size(108, 25);
            this.infobutton1.TabIndex = 7;
            this.infobutton1.Text = "Reseinfo";
            this.infobutton1.UseVisualStyleBackColor = true;
            this.infobutton1.Click += new System.EventHandler(this.infobutton1_Click);
            // 
            // tillbakaBtn
            // 
            this.tillbakaBtn.Location = new System.Drawing.Point(342, 409);
            this.tillbakaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.tillbakaBtn.Name = "tillbakaBtn";
            this.tillbakaBtn.Size = new System.Drawing.Size(108, 25);
            this.tillbakaBtn.TabIndex = 9;
            this.tillbakaBtn.Text = "Tillbaka";
            this.tillbakaBtn.UseVisualStyleBackColor = true;
            this.tillbakaBtn.Click += new System.EventHandler(this.tillbakaBtn_Click);
            // 
            // bussappDataSet1
            // 
            this.bussappDataSet1.DataSetName = "bussappDataSet1";
            this.bussappDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bussappDataSet1BindingSource
            // 
            this.bussappDataSet1BindingSource.DataSource = this.bussappDataSet1;
            this.bussappDataSet1BindingSource.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 268);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(275, 52);
            this.listBox1.TabIndex = 10;
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(133, 224);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 17);
            this.outputText.TabIndex = 11;
            // 
            // SokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 456);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tillbakaBtn);
            this.Controls.Add(this.infobutton1);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SokForm";
            this.Text = "sokform";
            this.Load += new System.EventHandler(this.SokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bussappDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussappDataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.Button tillbakaBtn;
        private System.Windows.Forms.BindingSource bussappDataSet1BindingSource;
        private bussappDataSet1 bussappDataSet1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label outputText;
    }
}