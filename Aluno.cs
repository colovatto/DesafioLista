using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLista
{
    internal class Aluno : Pessoa
    {
        private string _curso;
        private string _id, _matricula;
        private object pessoa;

        public Aluno()
        {
        }

      
        public Aluno(string nome, string telefone, string cidade, string rg, string cpf) : base(nome, telefone, cidade, rg, cpf)
        {
        }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf,
            string id, string matricula, string curso) : base(nome, telefone, cidade, rg, cpf)

        {
            _matricula = matricula;
            _curso = curso;
            _id = id;
        }
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
