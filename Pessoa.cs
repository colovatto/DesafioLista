using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLista
{
    internal class Pessoa
    {
        private string _nome, _telefone, _cidade, _rg, _cpf;

        public Pessoa()
        {
        }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            _nome = nome;
            _telefone = telefone;
            _cidade = cidade;
            _rg = rg;
            _cpf = cpf;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}
