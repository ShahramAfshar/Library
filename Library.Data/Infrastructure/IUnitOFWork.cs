
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Repository;


namespace library.Data
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        //1-Begin TransAction  2-Commit(SaveChange) 3-RollBack
        AzaRepository AzaRepository { get; }
        BookRepository BookRepository { get; }
        BorowRepository  BorowRepository { get; }
        WriterRepository WriterRepository { get; }
        CreditazaRepository CreditazaRepository { get; }
        BookExistRepository  BookExistRepository { get; }





        void Commit();
        Task<int> CommitAsync();


    }
}
