using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaApi.Domain.Models
{
    public class Jogo
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public Equipe Equipe1 { get; set; }
        public Equipe Equipe2 { get; set; }
        public Equipe Vencedor
        {
            get
            {
                if (Equipe1.Gols > Equipe2.Gols)
                {
                    return Equipe1;
                }
                else if (Equipe2.Gols > Equipe1.Gols)
                {
                    return Equipe2;
                }
                else
                {
                    //Se não for por qtd de gols, será por ordem alfabética
                    List<Equipe> listaEquipes = new List<Equipe>();
                    listaEquipes.Add(Equipe1);
                    listaEquipes.Add(Equipe2);
                    listaEquipes = (List<Equipe>)listaEquipes.OrderBy(x => x.Nome);
                    return listaEquipes.FirstOrDefault();
                }
            }
        }
    }
}

