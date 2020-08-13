using CopaApi.Domain.Interfaces.Repository;
using CopaApi.Domain.Models;
using CopaApi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Infra.Repositories
{
    public class EquipeRepository : BaseRepository<Equipe>, IEquipeRepository
    {
        public EquipeRepository(BDCopaContext Db)
            : base(Db)
        {
            _Db = Db;
        }

        
    }
}
