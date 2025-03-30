using System.ComponentModel.DataAnnotations;

namespace Todo.App.Core.Models;

public class TodoItem
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
}

