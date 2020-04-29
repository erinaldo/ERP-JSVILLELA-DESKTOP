namespace JSVILLELA
{
    partial class EntregasPrestador
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dgv_entregas = new System.Windows.Forms.DataGridView();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.lbl_entregas = new System.Windows.Forms.Label();
            this.lbl_itens = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(48, 17);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // dgv_entregas
            // 
            this.dgv_entregas.AllowUserToAddRows = false;
            this.dgv_entregas.AllowUserToDeleteRows = false;
            this.dgv_entregas.AllowUserToOrderColumns = true;
            this.dgv_entregas.AllowUserToResizeColumns = false;
            this.dgv_entregas.AllowUserToResizeRows = false;
            this.dgv_entregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_entregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_entregas.Location = new System.Drawing.Point(12, 67);
            this.dgv_entregas.MultiSelect = false;
            this.dgv_entregas.Name = "dgv_entregas";
            this.dgv_entregas.ReadOnly = true;
            this.dgv_entregas.RowHeadersVisible = false;
            this.dgv_entregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_entregas.Size = new System.Drawing.Size(200, 382);
            this.dgv_entregas.TabIndex = 1;
            this.dgv_entregas.SelectionChanged += new System.EventHandler(this.dgv_entregas_SelectionChanged);
            // 
            // dgv_itens
            // 
            this.dgv_itens.AllowUserToAddRows = false;
            this.dgv_itens.AllowUserToDeleteRows = false;
            this.dgv_itens.AllowUserToResizeColumns = false;
            this.dgv_itens.AllowUserToResizeRows = false;
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(224, 67);
            this.dgv_itens.MultiSelect = false;
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.ReadOnly = true;
            this.dgv_itens.RowHeadersVisible = false;
            this.dgv_itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itens.Size = new System.Drawing.Size(448, 382);
            this.dgv_itens.TabIndex = 2;
            // 
            // lbl_entregas
            // 
            this.lbl_entregas.AutoSize = true;
            this.lbl_entregas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_entregas.Location = new System.Drawing.Point(67, 47);
            this.lbl_entregas.Name = "lbl_entregas";
            this.lbl_entregas.Size = new System.Drawing.Size(61, 17);
            this.lbl_entregas.TabIndex = 3;
            this.lbl_entregas.Text = "Entregas";
            // 
            // lbl_itens
            // 
            this.lbl_itens.AutoSize = true;
            this.lbl_itens.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itens.Location = new System.Drawing.Point(376, 47);
            this.lbl_itens.Name = "lbl_itens";
            this.lbl_itens.Size = new System.Drawing.Size(108, 17);
            this.lbl_itens.TabIndex = 4;
            this.lbl_itens.Text = "Itens da entrega";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Image = global::JSVILLELA.Properties.Resources.Trash;
            this.btn_apagar.Location = new System.Drawing.Point(623, 12);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(49, 49);
            this.btn_apagar.TabIndex = 5;
            this.btn_apagar.UseVisualStyleBackColor = false;
            // 
            // EntregasPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSVILLELA.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_itens);
            this.Controls.Add(this.lbl_entregas);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.dgv_entregas);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntregasPrestador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entregas Prestador";
            this.Load += new System.EventHandler(this.EntregasPrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dgv_entregas;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Label lbl_entregas;
        private System.Windows.Forms.Label lbl_itens;
        private System.Windows.Forms.Button btn_apagar;
    }
}