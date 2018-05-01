using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IPonto.Xamarin.Models;
using SQLite;
using System.Linq;

namespace IPonto.Xamarin.Data
{
    public class IPontoDatabase : IPontoRepository
    {
        private readonly SQLiteAsyncConnection database;

        public IPontoDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CadastroEntrada>().Wait();
        }

        public Task<List<CadastroEntrada>> GetAllEntradasAsync()
        {
            return database.Table<CadastroEntrada>().ToListAsync();
        }

        public Task<CadastroEntrada> GetEntradaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntradaAsync(CadastroEntrada entrada)
        {
            if (entrada.IdEntrada != 0)
            {
                return database.UpdateAsync(entrada);
            }
            else
            {
                return database.InsertAsync(entrada);
            }
        }

        public Task<int> DeleteEntradaAsync(CadastroEntrada entrada)
        {
            throw new NotImplementedException();
        }

        public Task<CadastroEntrada> InsertEntradaAsync(CadastroEntrada entrada)
        {
            throw new NotImplementedException();
        }
    }
}
