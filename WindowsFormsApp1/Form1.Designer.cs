namespace WindowsFormsApp1
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
            this.lableKetQua = new System.Windows.Forms.Label();
            this.lableMon = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnEUR2VND = new System.Windows.Forms.Button();
            this.btnUSD2VND = new System.Windows.Forms.Button();
            this.btnVND2EUR = new System.Windows.Forms.Button();
            this.btnVND2USD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lableKetQua
            // 
            this.lableKetQua.AutoSize = true;
            this.lableKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableKetQua.Location = new System.Drawing.Point(184, 288);
            this.lableKetQua.Name = "lableKetQua";
            this.lableKetQua.Size = new System.Drawing.Size(86, 25);
            this.lableKetQua.TabIndex = 15;
            this.lableKetQua.Text = "Kết quả:";
            // 
            // lableMon
            // 
            this.lableMon.AutoSize = true;
            this.lableMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableMon.Location = new System.Drawing.Point(145, 138);
            this.lableMon.Name = "lableMon";
            this.lableMon.Size = new System.Drawing.Size(125, 25);
            this.lableMon.TabIndex = 14;
            this.lableMon.Text = "Tiền quy đổi:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(278, 291);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(378, 22);
            this.txtKetQua.TabIndex = 13;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(278, 138);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(378, 22);
            this.txtMoney.TabIndex = 12;
            // 
            // btnEUR2VND
            // 
            this.btnEUR2VND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEUR2VND.Location = new System.Drawing.Point(547, 219);
            this.btnEUR2VND.Name = "btnEUR2VND";
            this.btnEUR2VND.Size = new System.Drawing.Size(109, 36);
            this.btnEUR2VND.TabIndex = 11;
            this.btnEUR2VND.Text = "EUR2VND";
            this.btnEUR2VND.UseVisualStyleBackColor = true;
            this.btnEUR2VND.Click += new System.EventHandler(this.btnEUR2VND_Click);
            // 
            // btnUSD2VND
            // 
            this.btnUSD2VND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSD2VND.Location = new System.Drawing.Point(409, 219);
            this.btnUSD2VND.Name = "btnUSD2VND";
            this.btnUSD2VND.Size = new System.Drawing.Size(106, 36);
            this.btnUSD2VND.TabIndex = 10;
            this.btnUSD2VND.Text = "USD2VND";
            this.btnUSD2VND.UseVisualStyleBackColor = true;
            this.btnUSD2VND.Click += new System.EventHandler(this.btnUSD2VND_Click);
            // 
            // btnVND2EUR
            // 
            this.btnVND2EUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVND2EUR.Location = new System.Drawing.Point(278, 219);
            this.btnVND2EUR.Name = "btnVND2EUR";
            this.btnVND2EUR.Size = new System.Drawing.Size(104, 36);
            this.btnVND2EUR.TabIndex = 9;
            this.btnVND2EUR.Text = "VND2EUR";
            this.btnVND2EUR.UseVisualStyleBackColor = true;
            this.btnVND2EUR.Click += new System.EventHandler(this.btnVND2EUR_Click);
            // 
            // btnVND2USD
            // 
            this.btnVND2USD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVND2USD.Location = new System.Drawing.Point(150, 219);
            this.btnVND2USD.Name = "btnVND2USD";
            this.btnVND2USD.Size = new System.Drawing.Size(108, 36);
            this.btnVND2USD.TabIndex = 8;
            this.btnVND2USD.Text = "VND2USD";
            this.btnVND2USD.UseVisualStyleBackColor = true;
            this.btnVND2USD.Click += new System.EventHandler(this.btnVND2USD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lableKetQua);
            this.Controls.Add(this.lableMon);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnEUR2VND);
            this.Controls.Add(this.btnUSD2VND);
            this.Controls.Add(this.btnVND2EUR);
            this.Controls.Add(this.btnVND2USD);
            this.Name = "Form1";
            this.Text = "App đổi tiền tệ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableKetQua;
        private System.Windows.Forms.Label lableMon;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnEUR2VND;
        private System.Windows.Forms.Button btnUSD2VND;
        private System.Windows.Forms.Button btnVND2EUR;
        private System.Windows.Forms.Button btnVND2USD;
    }
}

