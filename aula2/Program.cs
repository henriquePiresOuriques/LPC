using System;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
           Conta objContaDoJoao = 
                new Conta(1234,
                      new Correntista(121, "joão da silva"));

            w($"Num. Conta: {objContaDoJoao.numero}.");
            
            w("Pressione uma tecla para encerrar");
            r();           
            
            objContaDoJoao.Depositar(1000);
            w($"Saldo do: {objContaDoJoao.correntista.nome} é {objContaDoJoao.saldo}.");
            r();
            objContaDoJoao.Sacar(500);
            w($"Saldo do:{objContaDoJoao.correntista.nome} é {objContaDoJoao.saldo}.");
            r();           
            
        }

       static void w(string msg)
        {
            Console.WriteLine(msg);
        }
        static void r()
        {
            
            Console.ReadLine();
        }
    }
}
