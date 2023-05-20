using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Code
{
    public interface IdataHelper<Tabel>
    {
        List<Tabel> GetAllData();
        List<Tabel> SearchtData(string item);
        Tabel Detailes(int id);

        void Adddata(object [] param);
        void Edit(int id);
        void Delete(int id);
    }
}
