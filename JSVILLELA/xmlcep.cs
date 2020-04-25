using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace JSVILLELA
{
    class XmlCep
    {
        #region Atributos
        private string logradouro;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        #endregion

        #region Propriedades

        public string Endereco
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        #endregion

        #region Métodos

        public void Buscacep(string cep)
        {
            XElement xml = XElement.Load("https://viacep.com.br/ws/"+cep+"/xml/");
            if (xml.HasElements)
            {
                if (xml.Element("erro") != null)
                    throw new Exception("CEP Inválido!");

                logradouro = xml.Element("logradouro").Value;
                complemento = xml.Element("complemento").Value;
                bairro = xml.Element("bairro").Value;
                localidade = xml.Element("localidade").Value;
                uf = xml.Element("uf").Value;

            }
        }

        #endregion
    }
}
