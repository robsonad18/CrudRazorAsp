using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudRazorAsp;

public class Premium
{
  [Key]
  [DisplayName("Id")]
  public string Id { get; set; }

  [Required(ErrorMessage = "Informe o titulo do Premium")]
  [StringLength(80, ErrorMessage = "Tamanho maximo do titulo é de 80 caracteres")]
  [MinLength(5, ErrorMessage = "Tamanho minumo do titulo é de 5 caracteres")]
  [DisplayName("Titulo")]
  public string Title { get; set; } = string.Empty;

  [DataType(DataType.DateTime)]
  [DisplayName("Inicio")]
  public DateTime StartDate { get; set; }

  [DataType(DataType.DateTime)]
  [DisplayName("Fim")]
  public DateTime EndDate { get; set; }

  [Required(ErrorMessage = "ID do aluno obrigatorio")]
  [DisplayName("Aluno")]
  public int StudentId { get; set; }

  public Student? Student { get; set; }
}
