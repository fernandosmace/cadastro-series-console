using System;
using DIO.Series.Enum;

namespace DIO.Series.Classes
{
    public class Serie : Entidadebase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(Guid Id, Genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public Guid retornaId()
        {
            return this.Id;
        }
    }
}