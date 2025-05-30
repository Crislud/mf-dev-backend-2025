﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório inforar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório inforar a Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório inforar o Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório inforar o Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
