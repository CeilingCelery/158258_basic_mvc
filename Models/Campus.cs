using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroMVC.Models
{
    public class Campus
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}