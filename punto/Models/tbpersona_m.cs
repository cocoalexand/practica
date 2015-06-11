using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbpersona
    {

    }

        public interface itbpersona {
        [Display(Name="Tu nombre")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object nombre { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idpersona { get; set; }
        }

        public interface itbpersona {
        [Display(Name="apelllido paterno")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object paterno{ get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object paterno { get; set; }
        }

        public interface itbpersona {
        [Display(Name="apellido materno")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object materno { get; set; }//nombre de la column  
        [ScaffoldColumn(false)]
        object materno { get; set; }
        }

        public interface itbpersona
        {
            [Display(Name = "cedula de identidad")]//nombre de los labels
            [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
            //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
            [Editable(false)]//no se podra editar
            [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object ci { get; set; }//nombre de la column
            [ScaffoldColumn(false)]
            object ci { get; set; }
        }

        public interface itbpersona {
        [Display(Name="fecha nacimiento")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object fechanac { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechanac { get; set; }
        }

        public interface itbpersona {
        [Display(Name="fecha creacion")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object fechacreacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechacreacion { get; set; }
        }

        public interface itbpersona {
        [Display(Name="fecha modificacion")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object fechamodificacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechamodificacion { get; set; }
        }
    
        public interface itbpersona {
        [Display(Name="estado")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object estado { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object estado { get; set; }
        }
 }