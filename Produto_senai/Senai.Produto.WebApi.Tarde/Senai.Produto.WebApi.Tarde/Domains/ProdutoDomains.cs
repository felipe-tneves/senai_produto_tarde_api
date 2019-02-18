using System.ComponentModel.DataAnnotations;

namespace Senai.Produto.WebApi.Tarde.Domains
{
    public class ProdutoDomains
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(150, MinimumLength =3, ErrorMessage = "Deve conter entre 3 e 150 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }
    }
}
