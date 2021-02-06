namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.genero + Evironment.NewLine;
            retorno += "Título:" + this.titulo + Evironment.NewLine;
            retorno += "Descrição: " + this.descricao + Evironment.NewLine;
            retorno += "Ano de Início: " + this.ano + Evironment.NewLine;
            return retorno;
        }

        public String retornaTitulo(){
            return this.Título
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}