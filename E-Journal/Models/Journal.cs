using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Journal.Models
{
    public class Journal
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        public Journal()
        {

        }
    }
}
