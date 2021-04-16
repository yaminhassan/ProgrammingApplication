using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGrades.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        public Comments(string comment)
        {
            Comment = comment;
        }
        
    }
}
