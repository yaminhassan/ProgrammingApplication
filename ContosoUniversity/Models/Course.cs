using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Module> Module { get; set; }
       

        public ICollection<Enrollment> Enrollments { get; set; }

        public void AddModules()
        {
            _ = new List<Module>()
            {
                new Module { ID = 1, Name = "Programming Concept", Mark = 50 },
                new Module { ID = 2, Name = "Compter Architecture", Mark = 70 },
                new Module { ID = 3, Name = "Web Development", Mark = 70 },
                new Module { ID = 2, Name = "Data Concept", Mark = 70 }

                
           };
        }
    }
}