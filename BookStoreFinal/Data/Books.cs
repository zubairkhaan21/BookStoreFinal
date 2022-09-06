using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreFinal.Data
{
    public class Books
    {
  
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPages { get; set; }

        //public DataTime CreatedOn { get; set; }
        //public DataTime? UpdatedOn { get; set; }
    }
}
 