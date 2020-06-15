using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTasks.Entities
{
    public class Tasks
    {
        [Key]
        public int taskNumber { get; set; }
        public string taskName { get; set; }

        [DataType(DataType.Date)]
        public DateTime taskCreateDate { get; set; }
        public string taskArea { get; set; }
        public string taskDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime taskDueDate { get; set; }
        public string taskPriority { get; set; }
        public string taskUser { get; set; }
        public string taskImage { get; set; }
        public int taskStatus { get; set; }
    }
}
