using System;

namespace APP.CadastroSeries
{
    public class serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao {get; set;}
        private int Ano {get; set;}

        private bool Excluido {get; set;}
        
        public serie(int id, Genero genero, string Titulo, string Descricao, int ano){

            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public serie(int id, Genero Genero, string Titulo, int Ano, string Descricao)
        {
            Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Ano = Ano;
            this.Descricao = Descricao;
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo(){
            return this.Titulo;
        }

        internal int retornaId(){
            return this.Id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}