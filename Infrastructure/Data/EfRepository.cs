using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T> where T : class
    {
        private readonly Context _context;
        public EfRepository(Context dbContext) : base(dbContext)
        { 
            _context = dbContext;
        }
    }
}
