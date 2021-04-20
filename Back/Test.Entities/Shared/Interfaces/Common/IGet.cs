using System.Threading.Tasks;

namespace Test.Entities.Shared.Interfaces.Common
{
    /// <summary>
    /// Interface para evento agregar
    /// </summary>
    /// <typeparam name="T">Objeto de datos de entrada</typeparam>
    /// <typeparam name="R">Objeto de datos de salida</typeparam>
    public interface IGet<T,R>
    {
        Task<R> Get(T item);
    }
}
