using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiveMVC5App.Data_Access
{
    public interface IDataAccesser
    {
        List<DataSet> GetDataFromTable();        
    }
}
