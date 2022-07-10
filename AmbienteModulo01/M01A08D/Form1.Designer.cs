namespace M01A08D
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDobro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(124, 15);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(71, 20);
            this.txtBox.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(211, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum
            // 
            this.lblNum.Location = new System.Drawing.Point(28, 44);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(296, 22);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "O Numero";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNum.Visible = false;
            // 
            // lblDobro
            // 
            this.lblDobro.Location = new System.Drawing.Point(28, 66);
            this.lblDobro.Name = "lblDobro";
            this.lblDobro.Size = new System.Drawing.Size(296, 17);
            this.lblDobro.TabIndex = 4;
            this.lblDobro.Text = "O Dobro";
            this.lblDobro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDobro.Visible = false;
            this.lblDobro.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 88);
            this.Controls.Add(this.lblDobro);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dobro do Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDobro;
    }
}

