using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskListApp.Models
{
    public class TaskList
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}