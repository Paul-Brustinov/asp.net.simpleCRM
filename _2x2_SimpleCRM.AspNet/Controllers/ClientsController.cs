using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Ninject.Activation;
using _2x2_SimpleCRM.DataLayerSQLite;
using _2x2_SimpleCRM.Repository;
using _2x2_SimpleCRM.Repository.Commnon;

namespace _2x2_SimpleCRM.AspNet.Controllers
{
    public class ClientsController : ApiController
    {
        private IGenericRepository<Client> RepoClient;
        private DbContext Context;

        public ClientsController(DbContext context, IGenericRepository<Client> repoClient)
        {
            this.Context = context;
            this.RepoClient = repoClient;
        }

        public JsonResult<List<Client>> GetAllClients()
        {
            return Json(RepoClient.GetAll().ToList());
        }
    }
}
