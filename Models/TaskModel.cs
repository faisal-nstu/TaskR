using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskR.Models
{
    public class TaskModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreationTime { get; set; }

        public TaskModel(string id, string title, bool isDone, DateTime creationTime)
        {
            this.Id = id;
            this.Title = title;
            this.IsDone = isDone;
            this.CreationTime = creationTime;
        }
    }
}
