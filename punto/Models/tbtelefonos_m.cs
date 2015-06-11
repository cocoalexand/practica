using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbtelefonos))]
    public class tbtelefonos
    {
    }
    public interface itbtelefonos
    {
        [Display(Name = "Tu telefono")]//nombre de los labels
        [DataType(DataType.PhoneNumber, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idtelefonos{ get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idtelefonos { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "numero")]//nombre de los labels
        [DataType(DataType.PhoneNumber, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object numero { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object numero { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "tipo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object tipo { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object tipo{ get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "codigo area")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object codigoarea { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object codigoarea { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "id lugares")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idlugares { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idlugares { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "fecha creacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object fechacreacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechacreacion { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "fecha modificacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object fechamodificacion { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fechamodificacion { get; set; }
    }
    public interface itbtelefonos
    {
        [Display(Name = "estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object estado { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object estado { get; set; }
    }
}