using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation_WebAPI.Dtos.EmployeeTaskDto
{
    public class UpdateEmployeeTaskDto
    {
        
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public DateTime? TaskDueDate { get; set; }
        public int EmployeeId { get; set; }
    }
}