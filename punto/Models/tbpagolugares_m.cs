using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbpagolugares))]
    public class tbpagolugares
    {
    }
    public interface itbpagolugares
    {
        [Display(Name = "idlugarpagos")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idlugarpagos { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idlugarpagos { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "idpago")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idpago { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idpago { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "idlugares")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idlugares { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idlugares { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "fecha")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fecha { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fecha { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "fechacreacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fechacreacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechacreacion { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "fechamodificacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fechamodificacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechamodificacion { get; set; }
    }
    public interface itbpagolugares
    {
        [Display(Name = "estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object estado { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object estado { get; set; }
    }


}