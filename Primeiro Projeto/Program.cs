namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;


            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade");
            cidade = Console.ReadLine();


            Console.WriteLine("nome: {0} ", nome);
            Console.WriteLine("idade: {0} anos", idade);
            Console.WriteLine("cidade: {0}", cidade);
            Console.WriteLine("Nome: {0} \n Idade: {1} anos \n cidade: {2}", nome, idade, cidade);
        }
    }
}