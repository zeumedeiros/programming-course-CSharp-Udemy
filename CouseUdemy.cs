namespace CouseUdemy
{

    public class Class1
    {
        static void Main(string[] args)
        {
            Produto P = new Produto();

            Console.WriteLine("Entre os dados do produto.");
            Console.WriteLine("Nome: ");
            P.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            P.Preco = Console.ReadLine();
            Console.WriteLine("Quantidade do produto: ");
            P.Quantidade = Console.ReadLine();
        }
    }

}
