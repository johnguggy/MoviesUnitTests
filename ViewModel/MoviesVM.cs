using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Web.ViewModel
{
    public class MoviesVM
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual int Price { get; set; }

        public virtual double SalesTax { get; set; }

        public virtual double Total { get; set; }
    }
}