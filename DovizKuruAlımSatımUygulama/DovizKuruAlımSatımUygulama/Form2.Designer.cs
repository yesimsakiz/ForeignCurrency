namespace DovizKuruAlımSatımUygulama
{
    partial class Form2
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
            this.cmbCurrency1 = new System.Windows.Forms.ComboBox();
            this.cmbCurrency2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrencyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblForexValue = new System.Windows.Forms.Label();
            this.txtCurrencyAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCurrency1
            // 
            this.cmbCurrency1.FormattingEnabled = true;
            this.cmbCurrency1.Location = new System.Drawing.Point(116, 42);
            this.cmbCurrency1.Name = "cmbCurrency1";
            this.cmbCurrency1.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrency1.TabIndex = 0;
            this.cmbCurrency1.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency1_SelectedIndexChanged);
            // 
            // cmbCurrency2
            // 
            this.cmbCurrency2.FormattingEnabled = true;
            this.cmbCurrency2.Location = new System.Drawing.Point(116, 69);
            this.cmbCurrency2.Name = "cmbCurrency2";
            this.cmbCurrency2.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrency2.TabIndex = 0;
            this.cmbCurrency2.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para Birimi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para Birimi :";
            // 
            // cmbCurrencyType
            // 
            this.cmbCurrencyType.FormattingEnabled = true;
            this.cmbCurrencyType.Location = new System.Drawing.Point(116, 96);
            this.cmbCurrencyType.Name = "cmbCurrencyType";
            this.cmbCurrencyType.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrencyType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doviz Tipi :";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(252, 41);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(75, 102);
            this.btnExchange.TabIndex = 2;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Döviz Değeri :";
            // 
            // lblForexValue
            // 
            this.lblForexValue.AutoSize = true;
            this.lblForexValue.Location = new System.Drawing.Point(202, 167);
            this.lblForexValue.Name = "lblForexValue";
            this.lblForexValue.Size = new System.Drawing.Size(13, 13);
            this.lblForexValue.TabIndex = 3;
            this.lblForexValue.Text = "0";
            // 
            // txtCurrencyAmount
            // 
            this.txtCurrencyAmount.Location = new System.Drawing.Point(116, 123);
            this.txtCurrencyAmount.Name = "txtCurrencyAmount";
            this.txtCurrencyAmount.Size = new System.Drawing.Size(121, 20);
            this.txtCurrencyAmount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Miktar :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 341);
            this.Controls.Add(this.txtCurrencyAmount);
            this.Controls.Add(this.lblForexValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurrencyType);
            this.Controls.Add(this.cmbCurrency2);
            this.Controls.Add(this.cmbCurrency1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurrency1;
        private System.Windows.Forms.ComboBox cmbCurrency2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrencyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblForexValue;
        private System.Windows.Forms.TextBox txtCurrencyAmount;
        private System.Windows.Forms.Label label5;
    }
}