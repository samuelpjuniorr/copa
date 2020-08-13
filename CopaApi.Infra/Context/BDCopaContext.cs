using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaApi.Infra.Context
{
    public class BDCopaContext : DbContext
    {
        private readonly IHttpContextAccessor _accessor;

        public BDCopaContext(DbContextOptions<BDCopaContext> options) : base(options)
        {

        }

        public BDCopaContext(DbContextOptions<BDCopaContext> options, IHttpContextAccessor accessor) : base(options)
        {
            _accessor = accessor;
        }
    

    }
}
