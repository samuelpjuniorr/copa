using System;

namespace CopaApi.Domain.Models
{
    public class Equipe
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int Gols { get; set; }
    }
}
