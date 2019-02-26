using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PractiveMVC5App.Data_Access
{
    public class DataAccesser : IDataAccesser
    {
        public List<DataSet> GetDataFromTable()
        {
            ProjectEntities projectEntities = new ProjectEntities();
            return projectEntities.DataSets.ToList();
        }
    }
}