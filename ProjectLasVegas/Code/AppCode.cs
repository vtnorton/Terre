using ProjectLasVegas.Code;
using System;

namespace ProjectLasVegas
{
    public class AppCode
    {
        string[] Questions;
        Random pickOneQuestion = new Random();

        public string SortDare(int Bottle)
        {
            switch (Bottle)
            {
                //Em sala de aula
                case 1:
                    Questions = new string[Desafio.Shared.Length + Desafio.AtClass.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.AtClass.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Casais
                case 2:
                    Questions = new string[Desafio.Shared.Length + Desafio.Couple.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.Couple.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Em família
                case 3:
                    Questions = new string[Desafio.Shared.Length + Desafio.Family.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.Family.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Com amigos
                case 4:
                    Questions = new string[Desafio.Shared.Length + Desafio.Friends.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.Friends.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Na praça
                case 5:
                    Questions = new string[Desafio.Shared.Length + Desafio.Park.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.Park.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Com os melhores
                case 6:
                    Questions = new string[Desafio.Shared.Length + Desafio.TheBests.Length];
                    Desafio.Shared.CopyTo(Questions, 0);
                    Desafio.TheBests.CopyTo(Questions, Desafio.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                default:
                    return "Nenhuma garrafa foi selecionada";
            }
        }

        public string SortTruth(int Bottle)
        {
            switch (Bottle)
            {
                //Em sala de aula
                case 1:
                    Questions = new string[Verdade.Shared.Length + Verdade.AtClass.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.AtClass.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Casais
                case 2:
                    Questions = new string[Verdade.Shared.Length + Verdade.Couple.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.Couple.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Em família
                case 3:
                    Questions = new string[Verdade.Shared.Length + Verdade.Family.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.Family.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Com amigos
                case 4:
                    Questions = new string[Verdade.Shared.Length + Verdade.Friends.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.Friends.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //No parque
                case 5:
                    Questions = new string[Verdade.Shared.Length + Verdade.Park.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.Park.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                //Com os melhores
                case 6:
                    Questions = new string[Verdade.Shared.Length + Verdade.TheBests.Length];
                    Verdade.Shared.CopyTo(Questions, 0);
                    Verdade.TheBests.CopyTo(Questions, Verdade.Shared.Length);
                    return Questions[pickOneQuestion.Next(0, Questions.Length + 1)];
                default:
                    return "Nenhuma garrafa foi selecionada";
            }
        }
    }
}
