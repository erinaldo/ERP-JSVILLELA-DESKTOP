namespace JSVILLELA.Relatórios
{
    partial class ReciboDePagamento
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
            this.rv_recibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_recibo
            // 
            this.rv_recibo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_recibo.AutoSize = true;
            this.rv_recibo.LocalReport.ReportEmbeddedResource = "JSVILLELA.Relatórios.ReciboPagamento.rdlc";
            this.rv_recibo.Location = new System.Drawing.Point(0, 0);
            this.rv_recibo.Name = "rv_recibo";
            this.rv_recibo.ServerReport.BearerToken = null;
            this.rv_recibo.Size = new System.Drawing.Size(784, 561);
            this.rv_recibo.TabIndex = 0;
            // 
            // ReciboDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rv_recibo);
            this.Name = "ReciboDePagamento";
            this.Text = "ReciboDePagamento";
            this.Load += new System.EventHandler(this.ReciboDePagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_recibo;
    }
}