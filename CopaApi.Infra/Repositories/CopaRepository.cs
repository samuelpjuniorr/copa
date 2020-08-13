using CopaApi.Domain.Interfaces.Repository;
using CopaApi.Domain.Models;
using CopaApi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Infra.Repositories
{
    public class CopaRepository : BaseRepository<Copa>, ICopaRepository
    {
        public CopaRepository(BDCopaContext Db)
            : base(Db)
        {
            _Db = Db;
        }

        
    }
}
