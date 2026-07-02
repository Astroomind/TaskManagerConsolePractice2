using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerConsolePractice2
{
    internal class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; init; }

        public TaskItem()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
