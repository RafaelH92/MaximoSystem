namespace MaximoSystem
{
    partial class frmCcustoDespesa
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
            this.btnCentroDeCusto = new System.Windows.Forms.Button();
            this.btnContaDespesa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCentroDeCusto
            // 
            this.btnCentroDeCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCentroDeCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCentroDeCusto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCentroDeCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentroDeCusto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentroDeCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCentroDeCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentroDeCusto.Location = new System.Drawing.Point(164, 195);
            this.btnCentroDeCusto.Name = "btnCentroDeCusto";
            this.btnCentroDeCusto.Size = new System.Drawing.Size(164, 41);
            this.btnCentroDeCusto.TabIndex = 1;
            this.btnCentroDeCusto.Text = "&Centro de Custo";
            this.btnCentroDeCusto.UseVisualStyleBackColor = false;
            this.btnCentroDeCusto.Click += new System.EventHandler(this.BtnCentroDeCusto_Click);
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
            this.btnContaDespesa.Location = new System.Drawing.Point(164, 261);
            this.btnContaDespesa.Name = "btnContaDespesa";
            this.btnContaDespesa.Size = new System.Drawing.Size(164, 43);
            this.btnContaDespesa.TabIndex = 1;
            this.btnContaDespesa.Text = "&Conta Despesa";
            this.btnContaDespesa.UseVisualStyleBackColor = false;
            this.btnContaDespesa.Click += new System.EventHandler(this.BtnContaDespesa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(160, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastros utilizados  na prestação de contas.\r\n";
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(164, 126);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(164, 43);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "&Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // frmCcustoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContaDespesa);
            this.Controls.Add(this.btnCentroDeCusto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCcustoDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadCustoDespesa";
            this.Load += new System.EventHandler(this.FrmCadCustoDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCentroDeCusto;
        private System.Windows.Forms.Button btnContaDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFuncionario;
    }
}