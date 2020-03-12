using System;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}")]
        public DateTime DateLocal => Date.ToLocalTime();

        [Display(Name = "Esta Disponible?")]
        public bool IsAvailable { get; set; }

        public Owner Owner { get; set; }

        public Pet Pet { get; set; }
    }
}
