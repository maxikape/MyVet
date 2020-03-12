using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {

        public int Id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "El campo {0}  no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Fixed Phone")]
        [MaxLength(20)]
        public string FixedPhone { get; set; }

        [Display(Name = "Cell Phone")]
        [MaxLength(20)]
        public string CellPhone { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";


        public ICollection<Pet> pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
