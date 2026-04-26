using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace mf_dev_backend_2023.Models
// esta classe foi criada na pasta Models para representar um veículo. Clicar com 
// Botão direito na pasta Models, escolher Add > Class, e nomear a classe como Veiculo.
{
    [Table("Veiculos")]
    public class Veiculo
    {
        //digitar prop e clicar na tecla Tab para criar uma propriedade automática.
        // [Key] é um atributo que indica que a propriedade Id é a chave primária da tabela no banco de dados. Isso significa que cada registro na tabela "Veiculos" será identificado exclusivamente por um valor único na coluna Id.
        [Key]
        public int Id { get; set; }

        // [Required] é um atributo que indica que a propriedade Nome é obrigatória. Isso significa que, ao tentar salvar um registro no banco de dados, o Entity Framework garantirá que o valor da propriedade Nome não seja nulo ou vazio. Se um valor inválido for fornecido, uma exceção será lançada.
        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O placa do veículo é obrigatória.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O ano de fabricação do veículo é obrigatório.")]
//Display abaixo cruza informação com o dysplay do Index e exibe o nome que queira no cabeçalho da tabela
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O ano do modelo do veículo é obrigatório.")]
        [Display(Name = "Ano Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
        }
}

// Após criar a classe e seus atributos é necessário realizar a impedância entre a classe e o banco de dados, para isso é necessário criar um arquivo de migração.
// [Table] é um atributo que indica o nome da tabela no banco de dados que corresponde a essa classe. Neste caso, a tabela será chamada "Veiculos". Se esse atributo não for especificado, o Entity Framework usará o nome da classe como nome da tabela por padrão.
// data annotations são usadas para configurar o comportamento do Entity Framework em relação ao mapeamento entre a classe e o banco de dados. Elas permitem que você defina regras de validação, restrições de banco de dados e outras configurações diretamente na classe do modelo.
// Foi criada a tabela, mas precisa conectar a um banco de dados. Instale Entity Framework Core e o Entity Framework Core SQL Server ou outro de banco de dados.