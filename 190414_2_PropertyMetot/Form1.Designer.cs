namespace _190414_2_PropertyMetot
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
            this.textBoxGetir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFiyatGetir = new System.Windows.Forms.Button();
            this.buttonFiyatCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGetir
            // 
            this.textBoxGetir.Location = new System.Drawing.Point(12, 28);
            this.textBoxGetir.Name = "textBoxGetir";
            this.textBoxGetir.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat";
            // 
            // textBoxCek
            // 
            this.textBoxCek.Location = new System.Drawing.Point(172, 28);
            this.textBoxCek.Name = "textBoxCek";
            this.textBoxCek.Size = new System.Drawing.Size(100, 20);
            this.textBoxCek.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // buttonFiyatGetir
            // 
            this.buttonFiyatGetir.Location = new System.Drawing.Point(12, 66);
            this.buttonFiyatGetir.Name = "buttonFiyatGetir";
            this.buttonFiyatGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonFiyatGetir.TabIndex = 2;
            this.buttonFiyatGetir.Text = "Fiyat Getir";
            this.buttonFiyatGetir.UseVisualStyleBackColor = true;
            // 
            // buttonFiyatCek
            // 
            this.buttonFiyatCek.Location = new System.Drawing.Point(172, 66);
            this.buttonFiyatCek.Name = "buttonFiyatCek";
            this.buttonFiyatCek.Size = new System.Drawing.Size(75, 23);
            this.buttonFiyatCek.TabIndex = 2;
            this.buttonFiyatCek.Text = "Fiyat Çel";
            this.buttonFiyatCek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 350);
            this.Controls.Add(this.buttonFiyatCek);
            this.Controls.Add(this.buttonFiyatGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCek);
            this.Controls.Add(this.textBoxGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFiyatGetir;
        private System.Windows.Forms.Button buttonFiyatCek;
    }
}

