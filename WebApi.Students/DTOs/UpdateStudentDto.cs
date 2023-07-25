using System.ComponentModel.DataAnnotations;

namespace Students.DTOs
{
    public record UpdateStudentDto
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(25, ErrorMessage = "Número de caracteres excedido")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(25, ErrorMessage = "Número de caracteres excedido")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 3, ErrorMessage = "Valor informado fora do intervalo permitido")]
        public int Gender { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(18, 125, ErrorMessage = "Valor informado fora do intervalo permitido")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [EmailAddress(ErrorMessage = "Endereço de e-mail informado inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Número de caracteres excedido")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(10, ErrorMessage = "Número de caracteres excedido")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Número de caracteres excedido")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Número de caracteres excedido")]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Número de caracteres excedido")]
        public string Street { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(5, ErrorMessage = "Número de caracteres excedido")]
        public string Number { get; set; } = string.Empty;
    }
}
