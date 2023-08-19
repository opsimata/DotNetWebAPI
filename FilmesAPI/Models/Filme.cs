using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage = "É obrigatório inserir o título do filme")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "É obrigatório inserir o gênero do filme")]
    [MaxLength(50, ErrorMessage = "O tamanho máximo de caracteres aceitos no campo gênero é 50")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "É obrigatório inserir a duração do filme")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
