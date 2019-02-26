using PractiveMVC5App.Data_Access;
using PractiveMVC5App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PractiveMVC5App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetDataFromCSV()
        {
            GetDataFromCSVModel model = new GetDataFromCSVModel();
            var dataAccesser = DependencyResolver.Current.GetService<IDataAccesser>();
            var dataFromCSV = dataAccesser.GetDataFromTable();
            if (dataFromCSV != null)
            {
                MapDataFromEntityToModel(dataFromCSV, model.lstDataFromCSV);
            }
            return View(model);
        }

        private void MapDataFromEntityToModel(List<DataSet> dataFromCSV, List<DataFromCSVModel> lstDataFromCSV)
        {
            foreach (var item in dataFromCSV)
            {
                DataFromCSVModel dataRow = new DataFromCSVModel();
                dataRow.Sno = item.Sno;
                dataRow.Item = item.Item;
                dataRow.Price = item.Price;
                dataRow.Quantity = item.Quantity;
                lstDataFromCSV.Add(dataRow);
            }
        }
    }
}