namespace JSVILLELA
{
    partial class EntradaEstoque
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
            this.lbl_prestador = new System.Windows.Forms.Label();
            this.lv_redes = new System.Windows.Forms.ListView();
            this.select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picbox_mais = new System.Windows.Forms.PictureBox();
            this.picbox_menos = new System.Windows.Forms.PictureBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_totalentrega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_mais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_menos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_prestador
            // 
            this.lbl_prestador.AutoSize = true;
            this.lbl_prestador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prestador.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prestador.Location = new System.Drawing.Point(36, 40);
            this.lbl_prestador.Name = "lbl_prestador";
            this.lbl_prestador.Size = new System.Drawing.Size(138, 17);
            this.lbl_prestador.TabIndex = 0;
            this.lbl_prestador.Text = "Código do Prestador:";
            // 
            // lv_redes
            // 
            this.lv_redes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.select,
            this.codigo,
            this.descricao,
            this.quantidade,
            this.peso,
            this.valor,
            this.total});
            this.lv_redes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_redes.FullRowSelect = true;
            this.lv_redes.HideSelection = false;
            this.lv_redes.LabelEdit = true;
            this.lv_redes.Location = new System.Drawing.Point(39, 163);
            this.lv_redes.MultiSelect = false;
            this.lv_redes.Name = "lv_redes";
            this.lv_redes.Size = new System.Drawing.Size(702, 216);
            this.lv_redes.TabIndex = 4;
            this.lv_redes.UseCompatibleStateImageBehavior = false;
            this.lv_redes.View = System.Windows.Forms.View.Details;
            // 
            // select
            // 
            this.select.Tag = "";
            this.select.Text = "";
            this.select.Width = 5;
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descricao.Width = 300;
            // 
            // quantidade
            // 
            this.quantidade.Text = "Quantidade";
            this.quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidade.Width = 90;
            // 
            // peso
            // 
            this.peso.Text = "Peso (Kg)";
            this.peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peso.Width = 80;
            // 
            // valor
            // 
            this.valor.Text = "Valor (R$)";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor.Width = 80;
            // 
            // total
            // 
            this.total.Text = "Total (R$)";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.Width = 80;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(180, 37);
            this.txt_codigo.MaxLength = 5;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(122, 25);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.lbl_data.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(379, 40);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(39, 17);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Data:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(424, 37);
            this.dateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(317, 25);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 24, 23, 59, 59, 0);
            // 
            // picbox_mais
            // 
            this.picbox_mais.BackColor = System.Drawing.Color.Transparent;
            this.picbox_mais.Image = global::JSVILLELA.Properties.Resources.mais;
            this.picbox_mais.Location = new System.Drawing.Point(701, 117);
            this.picbox_mais.Name = "picbox_mais";
            this.picbox_mais.Size = new System.Drawing.Size(40, 40);
            this.picbox_mais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_mais.TabIndex = 5;
            this.picbox_mais.TabStop = false;
            this.picbox_mais.Click += new System.EventHandler(this.picbox_mais_Click);
            this.picbox_mais.MouseEnter += new System.EventHandler(this.picbox_mais_MouseEnter);
            this.picbox_mais.MouseLeave += new System.EventHandler(this.picbox_mais_MouseLeave);
            // 
            // picbox_menos
            // 
            this.picbox_menos.BackColor = System.Drawing.Color.Transparent;
            this.picbox_menos.Image = global::JSVILLELA.Properties.Resources.menos;
            this.picbox_menos.Location = new System.Drawing.Point(655, 117);
            this.picbox_menos.Name = "picbox_menos";
            this.picbox_menos.Size = new System.Drawing.Size(40, 40);
            this.picbox_menos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_menos.TabIndex = 6;
            this.picbox_menos.TabStop = false;
            this.picbox_menos.Click += new System.EventHandler(this.pictureBox2_Click);
            this.picbox_menos.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.picbox_menos.MouseLeave += new System.EventHandler(this.picbox_menos_MouseLeave);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(36, 81);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(48, 17);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(90, 78);
            this.txt_nome.MaxLength = 60;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(651, 25);
            this.txt_nome.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::JSVILLELA.Properties.Resources.Lupa;
            this.pictureBox3.Location = new System.Drawing.Point(308, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(518, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_totalentrega
            // 
            this.lbl_totalentrega.AutoSize = true;
            this.lbl_totalentrega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalentrega.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalentrega.Location = new System.Drawing.Point(551, 399);
            this.lbl_totalentrega.Name = "lbl_totalentrega";
            this.lbl_totalentrega.Size = new System.Drawing.Size(157, 17);
            this.lbl_totalentrega.TabIndex = 12;
            this.lbl_totalentrega.Text = "Total da entrega: R$ 0,00";
            // 
            // EntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::JSVILLELA.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_totalentrega);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.picbox_menos);
            this.Controls.Add(this.picbox_mais);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lv_redes);
            this.Controls.Add(this.lbl_prestador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada de estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntradaEstoque_FormClosing);
            this.Load += new System.EventHandler(this.EntradaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_mais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_menos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prestador;
        private System.Windows.Forms.ColumnHeader select;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader quantidade;
        private System.Windows.Forms.ColumnHeader peso;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox picbox_mais;
        private System.Windows.Forms.PictureBox picbox_menos;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_totalentrega;
        public System.Windows.Forms.ListView lv_redes;
    }
}