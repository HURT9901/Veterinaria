using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Shared.Entidades
{
    public class Owner
    {
        
        public int Id { get; set; }
        [Display(Name = "Documento: ")]
        [MaxLength(30, ErrorMessage = "No se permite mas de 30 digitos.")]
        [Required(ErrorMessage="El campo {0} es obligatorio")]
        public string Document { get; set; }

        [Display(Name = "Nombre: ")]
        [MaxLength(30, ErrorMessage = "No se permite mas de 30 digitos.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido: ")]
        [MaxLength(30, ErrorMessage = "No se permite mas de 30 digitos.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string LastName { get; set; }
        [Display(Name = "Email: ")]
        [MaxLength(30, ErrorMessage = "No se permite mas de 30 digitos.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage ="Digite un Email valido")]
        public string Email { get; set; }
        public string FixedPhone { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
        public string FullName =>$"{FirstName}{LastName}";

    }
}
