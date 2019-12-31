using library.Data;
using library.Data.DatabaseContext;
using Library.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
     
    public interface IAzaRepository : IRepository<Aza>
    {
        //------Definition Private Functions Model -------------//
    //    IEnumerable<Tag> SingleNews(int newsId);

    }

    public class AzaRepository : Repository<Aza>, IAzaRepository
    {

        private readonly DbContext db;
        public AzaRepository(DbContext dbContext) : base(dbContext)
        {
            this.db = (this.db ?? (MyDbContext)db);
        }

        //public IEnumerable<Tag> SingleNews(int newsId)
        //{
        //    return GetAll().Where(t => t.NewsId == newsId).ToList();
        //}

    }
}
