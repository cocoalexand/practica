using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbusuario))]
    public class tbusuario
    {
    }
    public interface itbusuario
    {
        [Display(Name = "id usuario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idusuario { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idusuario { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "login")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object login { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object login { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "contraseña")]//nombre de los labels
        [DataType(DataType.Password, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object pass { get; set; }//nombre de la colum
        [ScaffoldColumn(false)]
        object pass { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "fid")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object fid { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object fid { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "email")]//nombre de los labels
        [DataType(DataType.EmailAddress, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object femail { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object femail { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "creado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se podra editar
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object creado { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object creado { get; set; }
    }
    public interface itbusuario
    {
        [Display(Name = "fecha de creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Tonto!!!!...")]//tipo de dato
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
    public interface itbusuario
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
    public interface itbusuario
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