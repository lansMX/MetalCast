using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MetalCast.Models
{
    public class Usuario
    {
        [Key]
        public int ID { set; get; }
        public int idnomina { set; get; }
        public int idpuesto { set; get; }
        public DateTime fehaRegistro { set; get; }
        [Required (ErrorMessage ="El nombre es obligatorio")]
        public String nombre { set; get; }
        public DateTime fechaNacimiento { set; get; }
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        public String usurioNombre { set; get; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public String usuarioPassword { set; get; }
        public int telefono { set; get; }
        public int celular { set; get; }
        public decimal sueldoBase { set; get; }
        public int numeroIMSS { set; get; }
        public String direccion { set; get; }
        public int antiguedad { set; get; }
        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        public String email { set; get; }
        public String emailEmpresa { set; get; }
        public int activo { set; get; }
        public int conectado { set; get; }
    }

}