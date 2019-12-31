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
     
    public interface IBorowRepository : IRepository<BorowBook>
    {
        //------Definition Private Functions Model -------------//
        //    IEnumerable<Tag> SingleNews(int newsId);

    }

    public class BorowRepository : Repository<BorowBook>, IBorowRepository
    {

        private readonly DbContext db;
        public BorowRepository(DbContext dbContext) : base(dbContext)
        {
            this.db = (this.db ?? (MyDbContext)db);
        }

        //public IEnumerable<Tag> SingleNews(int newsId)
        //{
        //    return GetAll().Where(t => t.NewsId == newsId).ToList();
        //}

    }
}
