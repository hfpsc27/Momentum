using System.ComponentModel.DataAnnotations;

namespace Momentum.UI.Models;

public class DocenteLocal
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(400, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(400, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
    [EmailAddress(ErrorMessage = "O campo {0} deve ser um endereço de e-mail válido.")]
    public string Email { get; set; } = string.Empty;
}
