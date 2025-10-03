using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model;

[Table("Tarefa")]
public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Titulo { get; set; }

    [StringLength(500)]
    public string? Descricao { get; set; }

    public DateTime DataCriacao { get; set; }

    [Required]
    [Column(TypeName = "bit(1)")]
    public bool Concluida { get; set; }
}
