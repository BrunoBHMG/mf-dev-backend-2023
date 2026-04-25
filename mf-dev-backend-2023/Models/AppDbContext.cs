using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023.Models
{
    // Esta classe foi criada para representar o contexto do banco de dados. Clicar com botão direito na pasta Models, escolher Add > Class, e nomear a
    //AppDbContext. O AppDbContext é uma classe que herda de DbContext, que é a classe base do Entity Framework Core para trabalhar com o banco de dados. O construtor da classe recebe um objeto DbContextOptions<AppDbContext> como parâmetro, que é usado para configurar as opções do contexto do banco de dados, como a string de conexão e outras configurações relacionadas ao banco de dados. O AppDbContext é responsável por gerenciar as entidades e as operações de acesso ao banco de dados, permitindo que você realize consultas, inserções, atualizações e exclusões de dados usando o Entity Framework Core.

    public class AppDbContext : DbContext
    {
        // A propriedade Veiculos é do tipo DbSet<Veiculo>, o que indica que ela representa uma coleção de entidades do tipo Veiculo no contexto do banco de dados. O Entity Framework Core usará essa propriedade para mapear a classe Veiculo para uma tabela no banco de dados e permitirá que você realize operações de consulta, inserção, atualização e exclusão de dados relacionados aos veículos.
        // options é um objeto que contém as opções de configuração para o contexto do banco de dados, como a string de conexão e outras configurações relacionadas ao banco de dados. Ele é passado para o construtor da classe base DbContext para configurar o contexto do banco de dados corretamente.
        // DbContenxt é a classe base do Entity Framework Core para trabalhar com o banco de dados. Ela fornece os métodos e propriedades necessários para realizar operações de acesso ao banco de dados, como consultas, inserções, atualizações e exclusões de dados.

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
     
    }
}
