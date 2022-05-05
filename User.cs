using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {   
        
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Empolyee Empolyee { get; set; }
        [Key]
        public String Task_id { get; set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public string Status { get; set; }
    }




        

    
}
