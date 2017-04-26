using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace ToDo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public Boolean Complete { get; set; }
        public DateTime AddeddDate { get; set; }
        

    }
}