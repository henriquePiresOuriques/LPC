namespace aula2
{
    public class Conta
    {
        public Conta (int numero, Correntista correntista){
            this.numero = numero;
            this.correntista = correntista;
        }
        public int numero {get; private set;}
        public Correntista correntista {get; private set;}
        public decimal saldo {get; private set;}

        public void Depositar (decimal valor){
            saldo += valor;
        }

        public void Sacar (decimal valor){
            saldo -= valor;
        }

    }
}