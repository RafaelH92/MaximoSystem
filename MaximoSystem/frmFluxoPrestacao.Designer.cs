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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoPrestacao));
            this.btnContaDespesa = new System.Windows.Forms.Button();
            this.btnFluxoCaixa = new System.Windows.Forms.Button();
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
            this.btnContaDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnContaDespesa.Image")));
            this.btnContaDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaDespesa.Location = new System.Drawing.Point(268, 217);
            this.btnContaDespesa.Name = "btnContaDespesa";
            this.btnContaDespesa.Size = new System.Drawing.Size(212, 56);
            this.btnContaDespesa.TabIndex = 2;
            this.btnContaDespesa.Text = "       &Prestação de Contas";
            this.btnContaDespesa.UseVisualStyleBackColor = false;
            // 
            // btnFluxoCaixa
            // 
            this.btnFluxoCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFluxoCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFluxoCaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFluxoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFluxoCaixa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFluxoCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFluxoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnFluxoCaixa.Image")));
            this.btnFluxoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFluxoCaixa.Location = new System.Drawing.Point(268, 115);
            this.btnFluxoCaixa.Name = "btnFluxoCaixa";
            this.btnFluxoCaixa.Size = new System.Drawing.Size(212, 56);
            this.btnFluxoCaixa.TabIndex = 3;
            this.btnFluxoCaixa.Text = "    &Fluxo de Caixa";
            this.btnFluxoCaixa.UseVisualStyleBackColor = false;
            // 
            // frmFluxoPrestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btnContaDespesa);
            this.Controls.Add(this.btnFluxoCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFluxoPrestacao";
            this.Text = "frmFluxoPrestacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaDespesa;
        private System.Windows.Forms.Button btnFluxoCaixa;
    }
}