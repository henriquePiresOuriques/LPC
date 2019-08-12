namespace aula2
{
    public class Correntista
    {
        public Correntista (int codigo, string nome){
            this.codigo = codigo;
            this.nome = nome;
        }
        public int codigo { get; private set; }
        public string nome {get; private set;}
    }
}