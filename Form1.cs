using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioLista
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Instância para ler o arquivo

            try
            {
                var texto = new StreamReader("Lista.txt", Encoding.UTF8);
                string aux;
                List<string> auxLista = new List<string>();
                List<Pessoa> listaPessoas = new List<Pessoa>();
                List<Aluno> listaAlunos = new List<Aluno>(); ;

                do
                {
                    aux = texto.ReadLine();
                    auxLista.Add(aux);

                } while (!texto.EndOfStream);
                texto.Close();

                for (int i = 0; i < auxLista.Count; i++)
                {
                    string linha = auxLista[i];


                    if (linha.StartsWith("Z"))
                    {
                        string[] infoPessoa = linha.Split('-');
                        string nome = infoPessoa[1];
                        string telefone = infoPessoa[2];
                        string cidade = infoPessoa[3];
                        string rg = infoPessoa[4];
                        string cpf = infoPessoa[5];

                        listaPessoas.Add(new Pessoa(nome, telefone, cidade, rg, cpf));
                    }

                    else if (linha != null && linha.StartsWith("Y"))
                    {

                        string[] infoCurso = linha.Split('-');
                        string id = infoCurso[1];
                        string matricula = infoCurso[2];
                        string curso = infoCurso[3];

                        listaAlunos.Add(new Aluno(listaPessoas.Last().Nome, listaPessoas.Last().Telefone, listaPessoas.Last().Cidade,
                        listaPessoas.Last().Rg, listaPessoas.Last().Cpf, id, matricula, curso));
                        

                    }
                }

                int contPessoas = listaPessoas.Count;
                textBox_numPessoas.Text = contPessoas.ToString();
                int numAlunos = listaAlunos.Count;
                textBox_numAlunos.Text = numAlunos.ToString();

                foreach(var aluno in listaAlunos)
                {
                    textBox_listaAlunos.Text = (aluno.Nome + " - " + aluno.Curso +  Environment.NewLine);
                }

                

            }



            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo ou arquivo não localizado!");

            }
        } 
    }
}


           


   


