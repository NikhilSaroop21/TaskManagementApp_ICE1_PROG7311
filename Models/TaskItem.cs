using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
