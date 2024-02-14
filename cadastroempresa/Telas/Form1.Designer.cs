namespace cadastroempresa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEmEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpresasCadastradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEmEmpresaToolStripMenuItem,
            this.listaDeEmpresasCadastradasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarEmEmpresaToolStripMenuItem
            // 
            this.cadastrarEmEmpresaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cadastrarEmEmpresaToolStripMenuItem.Name = "cadastrarEmEmpresaToolStripMenuItem";
            this.cadastrarEmEmpresaToolStripMenuItem.Size = new System.Drawing.Size(408, 30);
            this.cadastrarEmEmpresaToolStripMenuItem.Text = "Cadastrar  Empresa";
            this.cadastrarEmEmpresaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarEmEmpresaToolStripMenuItem_Click);
            // 
            // listaDeEmpresasCadastradasToolStripMenuItem
            // 
            this.listaDeEmpresasCadastradasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listaDeEmpresasCadastradasToolStripMenuItem.Name = "listaDeEmpresasCadastradasToolStripMenuItem";
            this.listaDeEmpresasCadastradasToolStripMenuItem.Size = new System.Drawing.Size(408, 30);
            this.listaDeEmpresasCadastradasToolStripMenuItem.Text = "Lista de Empresas cadastradas";
            this.listaDeEmpresasCadastradasToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpresasCadastradasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao company";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEmEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpresasCadastradasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

