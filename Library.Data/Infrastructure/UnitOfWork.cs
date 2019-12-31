
using Library.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace library.Data
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()

    {

        #region Fileds
        protected readonly DbContext db;

        #endregion

        #region Ctor
        public UnitOfWork()
        {
            db = new TContext();
        }

        #endregion

        #region Implement

        public void Commit()
        {
            db.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return db.SaveChangesAsync();
        }

        #endregion

        #region Repositories

        private AzaRepository azaRepository;
        public AzaRepository AzaRepository
        {
            get
            {
                if (azaRepository == null)
                {
                    azaRepository = new AzaRepository(db);
                }

                return azaRepository;
            }
        }

        private WriterRepository writerRepository;
        public WriterRepository WriterRepository
        {
            get
            {
                if (writerRepository == null)
                {
                    writerRepository = new WriterRepository(db);
                }

                return writerRepository;
            }
        }

        private BookRepository bookRepository;
        public BookRepository BookRepository
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BookRepository(db);
                }

                return bookRepository;
            }
        }

        private BorowRepository borowRepository;
        public BorowRepository BorowRepository
        {
            get
            {
                if (borowRepository == null)
                {
                    borowRepository = new BorowRepository(db);
                }

                return borowRepository;
            }
        }

        private CreditazaRepository creditazaRepository;
        public CreditazaRepository CreditazaRepository
        {
            get
            {
                if (creditazaRepository == null)
                {
                    creditazaRepository = new CreditazaRepository(db);
                }

                return creditazaRepository;
            }
        }

        private BookExistRepository bookExistRepository;
        public BookExistRepository BookExistRepository
        {
            get
            {
                if (bookExistRepository == null)
                {
                    bookExistRepository = new BookExistRepository(db);
                }

                return bookExistRepository;
            }
        }

        #endregion

        #region Dispose

        private bool disposed = false;


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion

    }
}
