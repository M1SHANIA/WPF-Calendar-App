using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Model
{
    public class EventModel
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public string Description { get; set; } 
        public List<TaskModel> Tasks { get; set; } 
    }

}
