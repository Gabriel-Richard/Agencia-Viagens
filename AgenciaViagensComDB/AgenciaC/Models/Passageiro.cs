using System.ComponentModel.DataAnnotations;

namespace AgenciaC.Models
{
    public class Passageiro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set;}

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string Cpf { get; set; }


        [Required]
        public int Viagem_id { get; set; }
        public Viagem Viagem { get; set;}
    }
}
