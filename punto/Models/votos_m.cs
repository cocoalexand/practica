using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbvotos))]
    public class votos
    {
    }
    public interface itbvotos
    {
        [Display(Name = "idusuario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object id { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object id{ get; set; }
    }
    public interface itbvotos
    {
        [Display(Name = "titulo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object titulo { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object titulo { get; set; }
    }
    public interface itbvotos
    {
        [Display(Name = "total votos")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object total_votes { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object total_votes { get; set; }
    }
    public interface itbvotos
    {
        [Display(Name = "total value")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object total_value { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object total_value { get; set; }
    }
    public interface itbvotos
    {
        [Display(Name = "usep_ips")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object usep_ips { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object usep_ips { get; set; }
    }
    public interface itbvotos
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
    public interface itbvotos
    {
        [Display(Name = "estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object estado{ get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object estado { get; set; }
    }

}