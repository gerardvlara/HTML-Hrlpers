using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace HTML_HELPERS.Models
{
    public class Register
    {
        [Required]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public string Apellido { get; set; }

        [Range(15, 99, ErrorMessage = "DEBES SER MAYOR DE 15")]
        public int Edad { get; set; }

        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Debe ingresar un mail válido")]
        public string Correo { get; set; }

        
        public string Genero { get; set; }

        public List<SelectListItem> getDatos()
        {
            List<SelectListItem> lista = new List<SelectListItem>();

            lista.Add(new SelectListItem() {
                Value = "1",
                Text = "--Selecciona--",
                Selected = true,
                Disabled = true
            });

            lista.Add(new SelectListItem() {
                Value = "2",
                Text = "Masculino",
                Selected = true,
            });

            lista.Add(new SelectListItem() {
                Value = "3",
                Text = "Femenino",
                Selected = true,
            });

            return lista;
        }

        //public enum Genero
        //{
        //    Masculino,
        //    Femenino
        //}

      
        public string Estado { get; set; }

     
        public string Hobbys { get; set; }


    }
}