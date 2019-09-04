namespace MatriculaDeAluno
{
    partial class FormMatriculaDeAluno
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaIdentificada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Ano Nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(106, 32);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(50, 20);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "An&o último aniversário:";
            // 
            // txtAnoUltimoAniversario
            // 
            this.txtAnoUltimoAniversario.Location = new System.Drawing.Point(281, 32);
            this.txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            this.txtAnoUltimoAniversario.Size = new System.Drawing.Size(50, 20);
            this.txtAnoUltimoAniversario.TabIndex = 5;
            this.txtAnoUltimoAniversario.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.txtAnoUltimoAniversario.Enter += new System.EventHandler(this.TxtAnoUltimoAniversario_Enter);
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(12, 61);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(117, 23);
            this.btnIdentificar.TabIndex = 6;
            this.btnIdentificar.Text = "Identificar Categoria";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria:";
            // 
            // txtCategoriaIdentificada
            // 
            this.txtCategoriaIdentificada.BackColor = System.Drawing.Color.Yellow;
            this.txtCategoriaIdentificada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCategoriaIdentificada.Location = new System.Drawing.Point(196, 61);
            this.txtCategoriaIdentificada.Name = "txtCategoriaIdentificada";
            this.txtCategoriaIdentificada.Size = new System.Drawing.Size(135, 23);
            this.txtCategoriaIdentificada.TabIndex = 8;
            this.txtCategoriaIdentificada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMatriculaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 88);
            this.Controls.Add(this.txtCategoriaIdentificada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.txtAnoUltimoAniversario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "FormMatriculaDeAluno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Matrícula de aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnoUltimoAniversario;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCategoriaIdentificada;
    }
}