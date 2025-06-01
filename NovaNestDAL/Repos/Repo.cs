using NovaNestDAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaNestDAL.Repos
{
    public class Repo
    {
        protected NovaNestDBContext db;
        internal Repo() { 
            db = new NovaNestDBContext();
        }
    }
}
