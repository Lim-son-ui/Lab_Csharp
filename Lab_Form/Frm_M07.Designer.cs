
namespace Lab_Form
{
    partial class Frm_M07
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
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btndiscount = new System.Windows.Forms.ComboBox();
            this.but_price = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(56, 45);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(206, 78);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "物件初始化";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "註冊事件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "resgister01";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(550, 142);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(135, 67);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "解除註冊";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(89, 186);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 3;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btndiscount
            // 
            this.btndiscount.FormattingEnabled = true;
            this.btndiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.btndiscount.Location = new System.Drawing.Point(89, 248);
            this.btndiscount.Name = "btndiscount";
            this.btndiscount.Size = new System.Drawing.Size(121, 20);
            this.btndiscount.TabIndex = 4;
            this.btndiscount.SelectedIndexChanged += new System.EventHandler(this.btndiscount_SelectedIndexChanged);
            // 
            // but_price
            // 
            this.but_price.Location = new System.Drawing.Point(88, 311);
            this.but_price.Name = "but_price";
            this.but_price.Size = new System.Drawing.Size(101, 38);
            this.but_price.TabIndex = 5;
            this.but_price.Text = "價格";
            this.but_price.UseVisualStyleBackColor = true;
            // 
            // Frm_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_price);
            this.Controls.Add(this.btndiscount);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn1);
            this.Name = "Frm_M07";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox btndiscount;
        private System.Windows.Forms.Button but_price;
    }
}