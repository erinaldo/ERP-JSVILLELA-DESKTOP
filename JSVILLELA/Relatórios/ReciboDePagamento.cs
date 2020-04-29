using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSVILLELA.Relatórios
{
    public partial class ReciboDePagamento : Form
    {
        string nome;
        string valor;
        string data;

        public ReciboDePagamento(string parametro1, string parametro2, string parametro3)
        {
            InitializeComponent();
            nome = parametro1;
            valor = parametro2;
            data = parametro3.Replace(":", "").Replace("00", "").Trim();
        }

        private void ReciboDePagamento_Load(object sender, EventArgs e)
        {
            MesAtual mes = new MesAtual();
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Nome", nome));
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Valor", valor));
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Data", data));
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Dia", System.DateTime.Now.Day.ToString()));
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Mes", mes.MesExtenso(System.DateTime.Now.Month)));
            this.rv_recibo.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Ano", System.DateTime.Now.Year.ToString()));
            this.rv_recibo.RefreshReport();
        }
    }
}
