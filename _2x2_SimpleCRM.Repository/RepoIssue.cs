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
    class RepoIssue : GenericRepository<Issue>
    {
        public RepoIssue(DbContext context) : base(context){}
    }
}
