using System.ComponentModel.DataAnnotations;

namespace AgenciaC.Models
{
    public class Viagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Origem { get; set; }

        [Required]
        public string Destino { get; set; }

        [Required]
        public float Preco { get; set; }

        [Required]
        public int Passageiro_id { get; set; }
        public Passageiro Passageiro  { get;set;}

    }
}
