using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_loginDB_07_10.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]

        public string Couriel { get; set; }
        [Required]

        public DateTime DateNaissance { get; set; }
        [Required]

        public string Matricule { get; set; }

        public string GSM { get; set; }
    }
}