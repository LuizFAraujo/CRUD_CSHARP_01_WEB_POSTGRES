using Microsoft.EntityFrameworkCore;

namespace AppCrudWeb.Models
{
    // Para o DBContext, localizado e instalado a versão mais recente do
    // EntityFrameworkCore (atual de hoje, 05/2022)
    public class Contexto : DbContext
    {

        // Construtor para receber o Options da Configurações que irá colocar no AppSettings
        // Que é a configuração de conexão com o banco
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }


        // DBSet
        // Avisa ao Core quais são os objetos devem ser criados quando executar o Migration
        // E quais são os objetos que serão gerenciados pelo Core
        public DbSet<Produto> Produtos { get; set; }



    }
}
