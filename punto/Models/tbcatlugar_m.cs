using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbcatlugar))]
    public class tbcatlugar
    {
    }
    public interface itbcatlugar
    {
        [Display(Name = "idcatlugares")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idcatlugares { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idcatlugares { get; set; }
    }
    public interface itbcatlugar
    {
        [Display(Name = "idcategorias")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object idcategorias { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idcategorias { get; set; }
    }
    public interface itbcatlugar
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
    public interface itbcatlugar
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
    public interface itbcatlugar
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
    public interface itbcatlugar
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