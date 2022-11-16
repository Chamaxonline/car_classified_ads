using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class VehicleCompany
    {
        [Key]
        public int Id { get; set; }

        public int ManualOrderNumber { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
