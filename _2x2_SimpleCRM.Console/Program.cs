using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2x2_SimpleCRM.DataLayerSQLite;
using _2x2_SimpleCRM.Repository;

namespace _2x2_SimpleCRM.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Model1 dbContext = new Model1();
            //System.Console.WriteLine(dbContext.Clients.Count());

            SqliteDbContext dbContext1 = new SqliteDbContext();
            System.Console.WriteLine(dbContext1.Clients.Count());
            System.Console.WriteLine(dbContext1.Issues.Count());


            RepoClient repoClient = new RepoClient(dbContext1);
            repoClient.GetAll().ToList().ForEach(c=>System.Console.WriteLine("{0} {1}", c.Id, c.Name));

        }
    }
}
