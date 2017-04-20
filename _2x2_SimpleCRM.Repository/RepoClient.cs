using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2x2_SimpleCRM.DataLayerSQLite;
using _2x2_SimpleCRM.Repository.Commnon;

namespace _2x2_SimpleCRM.Repository
{
    public class RepoClient : GenericRepository<Client>
    {
        public RepoClient(DbContext context): base(context) {}
    }
}
