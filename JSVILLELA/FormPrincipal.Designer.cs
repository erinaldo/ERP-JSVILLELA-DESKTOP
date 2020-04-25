namespace JSVILLELA
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestadorDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestadoresDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.redesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestadorDeServiçoToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // prestadorDeServiçoToolStripMenuItem
            // 
            this.prestadorDeServiçoToolStripMenuItem.Name = "prestadorDeServiçoToolStripMenuItem";
            this.prestadorDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.prestadorDeServiçoToolStripMenuItem.Text = "Prestador de Serviço";
            this.prestadorDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.prestadorDeServiçoToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestadoresDeServiçoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // prestadoresDeServiçoToolStripMenuItem
            // 
            this.prestadoresDeServiçoToolStripMenuItem.Name = "prestadoresDeServiçoToolStripMenuItem";
            this.prestadoresDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.prestadoresDeServiçoToolStripMenuItem.Text = "Prestadores de Serviço";
            this.prestadoresDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.prestadoresDeServiçoToolStripMenuItem_Click);
            // 
            // redesToolStripMenuItem
            // 
            this.redesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirEntradaToolStripMenuItem});
            this.redesToolStripMenuItem.Name = "redesToolStripMenuItem";
            this.redesToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.redesToolStripMenuItem.Text = "Estoque";
            // 
            // incluirEntradaToolStripMenuItem
            // 
            this.incluirEntradaToolStripMenuItem.Name = "incluirEntradaToolStripMenuItem";
            this.incluirEntradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incluirEntradaToolStripMenuItem.Text = "Incluir Entrada";
            this.incluirEntradaToolStripMenuItem.Click += new System.EventHandler(this.incluirEntradaToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JS VILLELA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestadorDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestadoresDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirEntradaToolStripMenuItem;
    }
}