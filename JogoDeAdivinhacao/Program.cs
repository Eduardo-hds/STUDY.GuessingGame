using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continiation = "X";
            int index;
            string questionAnswer;

            string[] questions = new string[]
            {
                "O que é, o que é? Feito para andar e não anda.",
                "O que é, o que é? Dá muitas voltas e não sai do lugar.",
                "O que é, o que é? Tem cabeça e tem dente, não é bicho e nem é gente.",
                "O que é, o que é? Não se come, mas é bom para se comer.",
                "O que é, o que é? Quanto mais rugas têm mais novo é."
            };

            string[] answers = new string[] 
            {
                "rua",
                "relógio",
                "alho",
                "talher",
                "pneu"
            };


            do
            {
                Random rand = new Random();
                index = rand.Next(questions.Length);

                Console.WriteLine("Responda a seguinte pergunta: ");
                Console.WriteLine(questions[index]);
                Console.WriteLine("Resposta: ");
                questionAnswer = Console.ReadLine();

                if (questionAnswer.ToLower() == answers[index].ToLower())
                {
                    Console.WriteLine("Parabéns, Você acertou!!!");
                    Console.WriteLine("Deseja continuar?[S/N]");
                    continiation = Console.ReadLine().ToLower();
                    
                }
                else 
                {
                    Console.WriteLine("Que pena, você errou. :(");
                    Console.WriteLine("Deseja tentar de novo?[S/N]");
                    continiation = Console.ReadLine().ToLower();
                } 

            } while (continiation != "n");

            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();

        }
    }
}
