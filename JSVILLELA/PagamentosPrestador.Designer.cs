namespace JSVILLELA
{
    partial class PagamentosPrestador
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
            this.dgv_pagamentos = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.dtp_pagamento = new System.Windows.Forms.DateTimePicker();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cb_forma = new System.Windows.Forms.ComboBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_forma = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(59, 21);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // dgv_pagamentos
            // 
            this.dgv_pagamentos.AllowUserToAddRows = false;
            this.dgv_pagamentos.AllowUserToDeleteRows = false;
            this.dgv_pagamentos.AllowUserToResizeRows = false;
            this.dgv_pagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pagamentos.Location = new System.Drawing.Point(13, 76);
            this.dgv_pagamentos.MultiSelect = false;
            this.dgv_pagamentos.Name = "dgv_pagamentos";
            this.dgv_pagamentos.ReadOnly = true;
            this.dgv_pagamentos.RowHeadersVisible = false;
            this.dgv_pagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pagamentos.Size = new System.Drawing.Size(343, 289);
            this.dgv_pagamentos.TabIndex = 1;
            this.dgv_pagamentos.SelectionChanged += new System.EventHandler(this.dgv_pagamentos_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::JSVILLELA.Properties.Resources.Add_New;
            this.btn_add.Location = new System.Drawing.Point(319, 34);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(37, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dtp_pagamento
            // 
            this.dtp_pagamento.Location = new System.Drawing.Point(445, 93);
            this.dtp_pagamento.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_pagamento.Name = "dtp_pagamento";
            this.dtp_pagamento.Size = new System.Drawing.Size(200, 29);
            this.dtp_pagamento.TabIndex = 3;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(445, 195);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(200, 29);
            this.txt_valor.TabIndex = 4;
            // 
            // cb_forma
            // 
            this.cb_forma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_forma.FormattingEnabled = true;
            this.cb_forma.Items.AddRange(new object[] {
            "Dinheiro",
            "Transferência"});
            this.cb_forma.Location = new System.Drawing.Point(445, 145);
            this.cb_forma.Name = "cb_forma";
            this.cb_forma.Size = new System.Drawing.Size(200, 29);
            this.cb_forma.TabIndex = 5;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.Location = new System.Drawing.Point(379, 99);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(47, 21);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "Data:";
            // 
            // lbl_forma
            // 
            this.lbl_forma.AutoSize = true;
            this.lbl_forma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_forma.Location = new System.Drawing.Point(379, 148);
            this.lbl_forma.Name = "lbl_forma";
            this.lbl_forma.Size = new System.Drawing.Size(60, 21);
            this.lbl_forma.TabIndex = 7;
            this.lbl_forma.Text = "Forma:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor.Location = new System.Drawing.Point(379, 198);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(52, 21);
            this.lbl_valor.TabIndex = 8;
            this.lbl_valor.Text = "Valor:";
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add.Location = new System.Drawing.Point(432, 42);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(168, 21);
            this.lbl_add.TabIndex = 9;
            this.lbl_add.Text = "Adicionar pagamento";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Location = new System.Drawing.Point(545, 263);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(100, 50);
            this.btn_adicionar.TabIndex = 10;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(383, 263);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 50);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Image = global::JSVILLELA.Properties.Resources.Minus;
            this.btn_excluir.Location = new System.Drawing.Point(276, 34);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(37, 36);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Image = global::JSVILLELA.Properties.Resources.Print;
            this.btn_imprimir.Location = new System.Drawing.Point(233, 34);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(37, 36);
            this.btn_imprimir.TabIndex = 13;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Visible = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // PagamentosPrestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSVILLELA.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(668, 376);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_forma);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.cb_forma);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.dtp_pagamento);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_pagamentos);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagamentosPrestador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagamentos do prestador";
            this.Load += new System.EventHandler(this.PagamentosPrestador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dgv_pagamentos;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dtp_pagamento;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cb_forma;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_forma;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_imprimir;
    }
}