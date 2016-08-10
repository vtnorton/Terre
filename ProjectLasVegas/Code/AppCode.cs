using System;
using System.IO;
using System.Linq;

namespace ProjectLasVegas
{
    public class AppCode
    {
        //TODO: There is a lot of coding repeating here. What a shame! 
        public string SortDare(int Garrafa)
        {
            Random randNumb = new Random();
            int PesoDaGarrafa = randNumb.Next(0, 100);
            switch (Garrafa)
            {
                case 1: //Sozinho
                    if (PesoDaGarrafa < 60)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Alone.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 2: //Na sala de aula
                    if (PesoDaGarrafa < 60)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\AtClass.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 3: //Casais
                    if (PesoDaGarrafa < 65)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Couple.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 4: //Bebados
                    if (PesoDaGarrafa < 70)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Drunks.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 5: //Familia
                    if (PesoDaGarrafa < 30)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Family.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 6: //Amigos
                    if (PesoDaGarrafa < 50)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Friends.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 7: //Na Praca
                    if (PesoDaGarrafa < 55)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Square.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                case 8: //Com as Bests
                    if (PesoDaGarrafa < 75)
                        return SortTrueOrDare("Data\\Dare\\pt-br\\TheBests.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\Dare\\pt-br\\Shared.txt"); //Compartilhado
                default:
                    return "Nenhuma garrafa conhecida foi selecionada. Experimente outra garrafa.";
            }
        }
        public string SortTrue(int Garrafa)
        {
            Random randNumb = new Random();
            int PesoDaGarrafa = randNumb.Next(0, 100);
            switch (Garrafa)
            {
                case 1: //Sozinho
                    if (PesoDaGarrafa < 60)
                        return SortTrueOrDare("Data\\True\\pt-br\\Alone.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 2: //Na sala de aula
                    if (PesoDaGarrafa < 80)
                        return SortTrueOrDare("Data\\True\\pt-br\\AtClass.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 3: //Casais
                    if (PesoDaGarrafa < 65)
                        return SortTrueOrDare("Data\\True\\pt-br\\Couple.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 4: //Bebados
                    if (PesoDaGarrafa < 50)
                        return SortTrueOrDare("Data\\True\\pt-br\\Drunks.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 5: //Familia
                    if (PesoDaGarrafa < 30)
                        return SortTrueOrDare("Data\\True\\pt-br\\Family.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 6: //Amigos
                    if (PesoDaGarrafa < 50)
                        return SortTrueOrDare("Data\\True\\pt-br\\Friends.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 7: //Na Praca
                    if (PesoDaGarrafa < 55)
                        return SortTrueOrDare("Data\\True\\pt-br\\Square.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                case 8: //Com as Bests
                    if (PesoDaGarrafa < 70)
                        return SortTrueOrDare("Data\\True\\pt-br\\TheBests.txt"); //Path da garrafa específica
                    else
                        return SortTrueOrDare("Data\\True\\pt-br\\Shared.txt"); //Compartilhado
                default:
                    return "Nenhuma garrafa conhecida foi selecionada. Experimente outra garrafa.";
            }
        }
        private string SortTrueOrDare(string Path)
        {
            Random randNumb = new Random();
            int LineNumberTxtFile, PerguntaSelecionada;
            string Pergunta;
            try
            {
                LineNumberTxtFile = File.ReadLines(@Path).Count();
                string[] perguntas = File.ReadAllLines(@Path);
                PerguntaSelecionada = randNumb.Next(0, LineNumberTxtFile);
                Pergunta = perguntas[PerguntaSelecionada];
            }
            catch
            {
                Pergunta = "Houve um erro ao carregar o arquivo da pergunta.";
            }
            return Pergunta;
        }
    }
}
