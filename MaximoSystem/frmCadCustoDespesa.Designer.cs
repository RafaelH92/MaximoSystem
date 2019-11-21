namespace MaximoSystem
{
    partial class frmCadCustoDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCustoDespesa));
            this.btnCentroDeCusto = new System.Windows.Forms.Button();
            this.btnContaDespesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCentroDeCusto
            // 
            this.btnCentroDeCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCentroDeCusto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCentroDeCusto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentroDeCusto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentroDeCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCentroDeCusto.Image = ((System.Drawing.Image)(resources.GetObject("btnCentroDeCusto.Image")));
            this.btnCentroDeCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentroDeCusto.Location = new System.Drawing.Point(268, 115);
            this.btnCentroDeCusto.Name = "btnCentroDeCusto";
            this.btnCentroDeCusto.Size = new System.Drawing.Size(212, 56);
            this.btnCentroDeCusto.TabIndex = 1;
            this.btnCentroDeCusto.Text = "&Centro de Custo";
            this.btnCentroDeCusto.UseVisualStyleBackColor = false;
            this.btnCentroDeCusto.Click += new System.EventHandler(this.BtnCentroDeCusto_Click);
            // 
            // btnContaDespesa
            // 
            this.btnContaDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContaDespesa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaDespesa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnContaDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnContaDespesa.Image")));
            this.btnContaDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContaDespesa.Location = new System.Drawing.Point(268, 217);
            this.btnContaDespesa.Name = "btnContaDespesa";
            this.btnContaDespesa.Size = new System.Drawing.Size(212, 56);
            this.btnContaDespesa.TabIndex = 1;
            this.btnContaDespesa.Text = "&Conta Despesa";
            this.btnContaDespesa.UseVisualStyleBackColor = false;
            // 
            // frmCadCustoDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btnContaDespesa);
            this.Controls.Add(this.btnCentroDeCusto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCustoDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadCustoDespesa";
            this.Load += new System.EventHandler(this.FrmCadCustoDespesa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCentroDeCusto;
        private System.Windows.Forms.Button btnContaDespesa;
    }
}