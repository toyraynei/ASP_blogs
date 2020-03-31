using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blogs.Model
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Post Date")]
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        
        [Display(Name = "Edit Date")]
        [DataType(DataType.Date)]
        public DateTime EditDate { get; set; }
        public string Context { get; set; }
        public string PostUser { get; set; }
    }
}
