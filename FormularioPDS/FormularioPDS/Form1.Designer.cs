namespace FormularioPDS
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
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btListarContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.Location = new System.Drawing.Point(12, 97);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(162, 29);
            this.btCadastrarContato.TabIndex = 0;
            this.btCadastrarContato.Text = "Cadastrar Contato";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Contato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btListarContato
            // 
            this.btListarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarContato.Location = new System.Drawing.Point(254, 107);
            this.btListarContato.Name = "btListarContato";
            this.btListarContato.Size = new System.Drawing.Size(162, 29);
            this.btListarContato.TabIndex = 2;
            this.btListarContato.Text = "Cadastrar Contato";
            this.btListarContato.UseVisualStyleBackColor = true;
            this.btListarContato.Click += new System.EventHandler(this.btListarContato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListarContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarContato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btListarContato;
    }
}

