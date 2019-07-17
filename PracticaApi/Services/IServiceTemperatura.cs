using System.Collections.Generic;
using System.Linq;
namespace PracticaApi
{
    public interface IServiceTemperatura
    {
        List<Temperatura> GetAll();
        Temperatura Get(int id);
        void Save(Temperatura temperatura);
        void Delete (int id);
    }
}
