namespace ArquivoForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCriar = new Button();
            btnAbrir = new Button();
            btnConcatenar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(135, 75);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(284, 34);
            btnCriar.TabIndex = 0;
            btnCriar.Text = "Criar Aquivo";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(135, 133);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(284, 34);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir Arquivo";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnConcatenar
            // 
            btnConcatenar.Location = new Point(135, 196);
            btnConcatenar.Name = "btnConcatenar";
            btnConcatenar.Size = new Size(284, 34);
            btnConcatenar.TabIndex = 2;
            btnConcatenar.Text = "Concatenar Arquivo";
            btnConcatenar.UseVisualStyleBackColor = true;
            btnConcatenar.Click += btnConcatenar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(135, 249);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(284, 34);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar Arquivo";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(135, 306);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(284, 34);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir Arquivo";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 441);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnConcatenar);
            Controls.Add(btnAbrir);
            Controls.Add(btnCriar);
            Name = "Form1";
            Text = "Manipulando Arquivo de Texto em C#";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriar;
        private Button btnAbrir;
        private Button btnConcatenar;
        private Button btnAlterar;
        private Button btnExcluir;
    }
}