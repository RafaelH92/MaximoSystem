namespace MaximoSystem
{
    partial class frmFluxoPrestacao
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
            this.btnContaDespesa = new System.Windows.Forms.Button();
            this.btnFluxoCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContaDespesa
            // 
            this.btnContaDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContaDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContaDespesa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaDespesa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnContaDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaDespesa.Location = new System.Drawing.Point(164, 201);
            this.btnContaDespesa.Name = "btnContaDespesa";
            this.btnContaDespesa.Size = new System.Drawing.Size(164, 47);
            this.btnContaDespesa.TabIndex = 2;
            this.btnContaDespesa.Text = "&Prestação de Contas";
            this.btnContaDespesa.UseVisualStyleBackColor = false;
            this.btnContaDespesa.Click += new System.EventHandler(this.BtnContaDespesa_Click);
            // 
            // btnFluxoCaixa
            // 
            this.btnFluxoCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFluxoCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFluxoCaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFluxoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFluxoCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFluxoCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFluxoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFluxoCaixa.Location = new System.Drawing.Point(164, 106);
            this.btnFluxoCaixa.Name = "btnFluxoCaixa";
            this.btnFluxoCaixa.Size = new System.Drawing.Size(164, 41);
            this.btnFluxoCaixa.TabIndex = 3;
            this.btnFluxoCaixa.Text = " &Fluxo de Caixa";
            this.btnFluxoCaixa.UseVisualStyleBackColor = false;
            this.btnFluxoCaixa.Click += new System.EventHandler(this.BtnFluxoCaixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(160, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Controle as movimentações de caixa.\r\n";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(160, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Realize as prestações de contas ";
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // frmFluxoPrestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContaDespesa);
            this.Controls.Add(this.btnFluxoCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFluxoPrestacao";
            this.Text = "frmFluxoPrestacao";
            this.Load += new System.EventHandler(this.FrmFluxoPrestacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContaDespesa;
        private System.Windows.Forms.Button btnFluxoCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}