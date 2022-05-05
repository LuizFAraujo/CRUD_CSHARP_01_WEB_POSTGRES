using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCrudWeb.Models
{
    [Table("Produto")] // nome da tabela, se for o mesmo da classe não é necessário
    public class Produto
    {
        [Column("Id")] // nome da coluna, se for o mesmo da variável não é necessário
        [Display(Name = "Código")] // é o que irá aparecer na tela
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }



    }
}
