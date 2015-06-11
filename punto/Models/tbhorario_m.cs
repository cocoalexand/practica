using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbhorario))]
    public class tbhorario
    {
    }
    public interface itbhorario
    {
        [Display(Name = "idhorario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idhorario { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idhorario { get; set; }
    }
    public interface itbhorario
    {
        [Display(Name = "inicio")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object inicio { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object inicio { get; set; }
    }
    public interface itbhorario
    {
        [Display(Name = "fin")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fin { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fin { get; set; }
    }
    public interface itbhorario
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
    public interface itbhorario
    {
        [Display(Name = "tipo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object tipo { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object tipo { get; set; }
    }
    public interface itbhorario
    {
        [Display(Name = "fechacreacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
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
    public interface itbhorario
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