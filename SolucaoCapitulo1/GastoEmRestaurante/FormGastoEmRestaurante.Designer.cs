namespace GastoEmRestaurante
{
    partial class FormGastoEmRestaurante
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
            this.Despesa = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.txtTotalServico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Despesa
            // 
            this.Despesa.AutoSize = true;
            this.Despesa.Location = new System.Drawing.Point(12, 18);
            this.Despesa.Name = "Despesa";
            this.Despesa.Size = new System.Drawing.Size(52, 13);
            this.Despesa.TabIndex = 0;
            this.Despesa.Text = "Despesa:";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(70, 15);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtDespesa.TabIndex = 1;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(176, 13);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 2;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Blue;
            this.Total.Location = new System.Drawing.Point(12, 47);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(94, 13);
            this.Total.TabIndex = 3;
            this.Total.Text = "Total com 10%:";
            // 
            // txtTotalServico
            // 
            this.txtTotalServico.BackColor = System.Drawing.Color.Yellow;
            this.txtTotalServico.Enabled = false;
            this.txtTotalServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalServico.Location = new System.Drawing.Point(112, 44);
            this.txtTotalServico.Name = "txtTotalServico";
            this.txtTotalServico.Size = new System.Drawing.Size(139, 20);
            this.txtTotalServico.TabIndex = 4;
            // 
            // FormGastoEmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 68);
            this.Controls.Add(this.txtTotalServico);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.Despesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGastoEmRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGastoEmRestaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Despesa;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtTotalServico;
    }
}