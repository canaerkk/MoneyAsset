using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyAsset.Models.ViewModels
{
    public class DetailsViewModels
    {
        public int Id { get; set; }
        public string Categories { get; set; }
        public DateTime CreateDate { get; set; }
        public int Cost { get; set; }
        public string Remark { get; set; }
    }
}