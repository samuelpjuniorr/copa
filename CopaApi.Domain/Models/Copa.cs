using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;

namespace CopaApi.Domain.Models
{
    public class Copa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public List<Equipe> EquipesParticipantes { get; set; }
        public List<Jogo> JogosPrimeiraFase
        {
            get
            {
                if (EquipesParticipantes.Any())
                {
                    int qtdEquipes = EquipesParticipantes.Count;
                    List<Jogo> listaJogos = new List<Jogo>();

                    for (int i = 0; i < (qtdEquipes / 2); i++)
                    {
                        Jogo jogo = new Jogo
                        {
                            Nome = "Primera Fase: " + EquipesParticipantes[i].Nome.Trim() + " VS " + EquipesParticipantes[qtdEquipes - (i + 1)].Nome.Trim(),
                            Equipe1 = EquipesParticipantes[i],
                            Equipe2 = EquipesParticipantes[qtdEquipes - (i+1)]

                        };

                        listaJogos.Add(jogo);
                    }

                    return listaJogos;
                }

                return new List<Jogo>();
            }
        }

        public List<Jogo> JogosSemifinais
        {
            get
            {
                if (JogosPrimeiraFase.Any())
                {

                    List<Jogo> listaJogos = new List<Jogo>();

                    int qtd = 0;
                    for (int i = 0; i < JogosPrimeiraFase.Count; i++)
                    {
                        qtd++;
                        if (qtd % 2 == 0)//Quando achar o par
                        {
                            Jogo jogo = new Jogo
                            {
                                Nome = "SemiFinal: " + JogosPrimeiraFase[i - 1].Vencedor.Nome.Trim() + " VS " + JogosPrimeiraFase[i].Vencedor.Nome.Trim(),
                                Equipe1 = JogosPrimeiraFase[i - 1].Vencedor,
                                Equipe2 = JogosPrimeiraFase[i].Vencedor

                            };
                            listaJogos.Add(jogo);
                        }

                    }


                    return listaJogos;
                }

                return new List<Jogo>();
            }
        }

        public List<Jogo> JogoFinal
        {
            get
            {
                if (JogosSemifinais.Any())
                {

                    List<Jogo> listaJogos = new List<Jogo>();

                    int qtd = 0;
                    for (int i = 0; i < JogosSemifinais.Count; i++)
                    {
                        qtd++;
                        if (qtd % 2 == 0)//Quando achar o par
                        {
                            Jogo jogo = new Jogo
                            {
                                Nome = "SemiFinal: " + JogosSemifinais[i - 1].Vencedor.Nome.Trim() + " VS " + JogosSemifinais[i].Vencedor.Nome.Trim(),
                                Equipe1 = JogosSemifinais[i - 1].Vencedor,
                                Equipe2 = JogosSemifinais[i].Vencedor

                            };
                            listaJogos.Add(jogo);
                        }

                    }


                    return listaJogos;
                }

                return new List<Jogo>();
            }
        }

    }
}
