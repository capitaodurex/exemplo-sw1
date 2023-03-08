namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        Exemplo exe96 = new Exemplo();

        exe96.mostramsg();

        exe96.pegaNome("ANDERSON");

       Console.WriteLine(exe96.mensagem());

       Console.WriteLine("O resultado da soma é: " + exe96.somar(10,20));

    }
}
