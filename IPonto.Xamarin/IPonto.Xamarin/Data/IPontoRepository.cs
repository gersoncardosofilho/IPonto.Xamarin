using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IPonto.Xamarin.Models;

namespace IPonto.Xamarin.Data
{
    public interface IPontoRepository
    {
        Task<List<CadastroEntrada>> GetAllEntradasAsync();
        Task<CadastroEntrada> GetEntradaAsync(int id);
        Task<int> SaveEntradaAsync(CadastroEntrada entrada);
        Task<int> DeleteEntradaAsync(CadastroEntrada entrada);
        Task<CadastroEntrada> InsertEntradaAsync(CadastroEntrada entrada);

    }
}
