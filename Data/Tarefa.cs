using System.ComponentModel.DataAnnotations.Schema;

namespace APIcomDapper.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);




