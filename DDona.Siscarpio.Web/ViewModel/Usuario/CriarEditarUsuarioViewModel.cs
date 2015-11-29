using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDona.Siscarpio.Web.ViewModel.Usuario
{
    public class CriarEditarUsuarioViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(20, ErrorMessage = "Limite de {1} caracteres")]
        public string Username { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(80, ErrorMessage = "Limite de {1} caracteres")]
        public string Nome { get; set; }
    }
}