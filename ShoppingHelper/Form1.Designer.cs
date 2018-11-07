namespace ShoppingHelper
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.walMartCheckBx = new System.Windows.Forms.CheckBox();
            this.targetCheckBx = new System.Windows.Forms.CheckBox();
            this.amazonCheckBx = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amazonLabel1 = new System.Windows.Forms.Label();
            this.amazonPrice1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amazonLabel2 = new System.Windows.Forms.Label();
            this.amazonPrice2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(225, 43);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(147, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What are you looking for?";
            // 
            // walMartCheckBx
            // 
            this.walMartCheckBx.AutoSize = true;
            this.walMartCheckBx.Location = new System.Drawing.Point(40, 107);
            this.walMartCheckBx.Name = "walMartCheckBx";
            this.walMartCheckBx.Size = new System.Drawing.Size(69, 17);
            this.walMartCheckBx.TabIndex = 2;
            this.walMartCheckBx.Text = "Wal-Mart";
            this.walMartCheckBx.UseVisualStyleBackColor = true;
            // 
            // targetCheckBx
            // 
            this.targetCheckBx.AutoSize = true;
            this.targetCheckBx.Location = new System.Drawing.Point(170, 107);
            this.targetCheckBx.Name = "targetCheckBx";
            this.targetCheckBx.Size = new System.Drawing.Size(57, 17);
            this.targetCheckBx.TabIndex = 3;
            this.targetCheckBx.Text = "Target";
            this.targetCheckBx.UseVisualStyleBackColor = true;
            // 
            // amazonCheckBx
            // 
            this.amazonCheckBx.AutoSize = true;
            this.amazonCheckBx.Location = new System.Drawing.Point(308, 107);
            this.amazonCheckBx.Name = "amazonCheckBx";
            this.amazonCheckBx.Size = new System.Drawing.Size(64, 17);
            this.amazonCheckBx.TabIndex = 4;
            this.amazonCheckBx.Text = "Amazon";
            this.amazonCheckBx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Where to look?";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(195, 155);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amazonPrice2);
            this.groupBox1.Controls.Add(this.amazonLabel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amazonPrice1);
            this.groupBox1.Controls.Add(this.amazonLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 248);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amazon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "1";
            // 
            // amazonLabel1
            // 
            this.amazonLabel1.AutoSize = true;
            this.amazonLabel1.Location = new System.Drawing.Point(39, 40);
            this.amazonLabel1.Name = "amazonLabel1";
            this.amazonLabel1.Size = new System.Drawing.Size(35, 13);
            this.amazonLabel1.TabIndex = 1;
            this.amazonLabel1.Text = "label4";
            // 
            // amazonPrice1
            // 
            this.amazonPrice1.AutoSize = true;
            this.amazonPrice1.Location = new System.Drawing.Point(39, 69);
            this.amazonPrice1.Name = "amazonPrice1";
            this.amazonPrice1.Size = new System.Drawing.Size(35, 13);
            this.amazonPrice1.TabIndex = 2;
            this.amazonPrice1.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2";
            // 
            // amazonLabel2
            // 
            this.amazonLabel2.AutoSize = true;
            this.amazonLabel2.Location = new System.Drawing.Point(42, 108);
            this.amazonLabel2.Name = "amazonLabel2";
            this.amazonLabel2.Size = new System.Drawing.Size(35, 13);
            this.amazonLabel2.TabIndex = 4;
            this.amazonLabel2.Text = "label5";
            // 
            // amazonPrice2
            // 
            this.amazonPrice2.AutoSize = true;
            this.amazonPrice2.Location = new System.Drawing.Point(42, 130);
            this.amazonPrice2.Name = "amazonPrice2";
            this.amazonPrice2.Size = new System.Drawing.Size(35, 13);
            this.amazonPrice2.TabIndex = 5;
            this.amazonPrice2.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amazonCheckBx);
            this.Controls.Add(this.targetCheckBx);
            this.Controls.Add(this.walMartCheckBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Shopping Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox walMartCheckBx;
        private System.Windows.Forms.CheckBox targetCheckBx;
        private System.Windows.Forms.CheckBox amazonCheckBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label amazonPrice2;
        private System.Windows.Forms.Label amazonLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label amazonPrice1;
        private System.Windows.Forms.Label amazonLabel1;
        private System.Windows.Forms.Label label3;
    }
}

