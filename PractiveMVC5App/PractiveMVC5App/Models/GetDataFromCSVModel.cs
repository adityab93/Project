using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PractiveMVC5App.Models
{
    public class GetDataFromCSVModel
    {
        public GetDataFromCSVModel()
        {
            lstDataFromCSV = new List<DataFromCSVModel>();
        }

        public List<DataFromCSVModel> lstDataFromCSV { get; set; }
    }

    public class DataFromCSVModel
    {
        [Display(Name = "Sno")]
        public int Sno { get; set; }
        [Display(Name = "Item")]
        public string Item { get; set; }
        [Display(Name = "Price")]
        public Nullable<double> Price { get; set; }
        [Display(Name = "Quantity")]
        public Nullable<int> Quantity { get; set; }
    }
}