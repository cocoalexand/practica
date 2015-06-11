using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbvotousuario))]
    public class tbvotousuario
    {
    }
    public interface itbvotousuario
    {
        [Display(Name = "id voto usuario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idvotousuario { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idvotousuario { get; set; }
    }
    public interface itbvotousuario
    {
        [Display(Name = "id lugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idlugar { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object idlugar{ get; set; }
    }
    public interface itbvotousuario
    {
        [Display(Name = "id usuario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object iduser { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object iduser { get; set; }
    }
    public interface itbvotousuario
    {
        [Display(Name = "scor")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object scor { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object scor { get; set; }
    }
    public interface itbvotousuario
    {
        [Display(Name = "fecha de creacion")]//nombre de los labels
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
    public interface itbvotousuario
    {
        [Display(Name = "fecha de modificacion")]//nombre de los labels
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
    public interface itbvotousuario
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
        object estado{ get; set; }
    }
}