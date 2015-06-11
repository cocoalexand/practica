using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itb_lugar_voto))]
    public class tb_lugar_voto
    {
        public void prueba()
        {
        
        }
    }
    public interface itb_lugar_voto
    {
        [Display(Name = "id_voto")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000, 15000000)]
        object idvoto { get; set; }//nombre de la column
        [Key]
        [ScaffoldColumn(false)]
        object idvoto { get; set; }
    }

        public interface itb_lugar_voto {
        [Display(Name="titulo")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object titulo { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object titulo{ get; set; }
        }
       
        public interface itb_lugar_voto {
        [Display(Name="num_votes")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Required]
        [Range(60000,15000000)]
        object num_votes { get; set; }//nombre de la column
        [ScaffoldColumn(false)]
        object num_votes{ get; set; }
        }

        public interface itb_lugar_voto
        {
            [Display(Name = "total_score")]//nombre de los labels
            [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
            //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
            [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object total_score { get; set; }//nombre de la column
            [ScaffoldColumn(false)]
            object total_score { get; set; }
        }
        public interface itb_lugar_voto
        {
            [Display(Name = "rating")]//nombre de los labels
            [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
            //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
            [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object rating { get; set; }//nombre de la column
            [ScaffoldColumn(false)]
            object rating { get; set; }
        }
        public interface itb_lugar_voto
        {
            [Display(Name = "id")]//nombre de los labels
            [DataType(DataType.PhoneNumber, ErrorMessage = "Error")]//tipo de dato
            //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
            [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object id { get; set; }//nombre de la column
            [ScaffoldColumn(false)]
            object id { get; set; }
        }
        public interface itb_lugar_voto
        {
            [Display(Name = "fechacreacion")]//nombre de los labels
            [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
            //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
            [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
            [StringLength(20)]//max 20
            [Required]
            [Range(60000, 15000000)]
            object fechacreacion { get; set; }//nombre de la column
            [ScaffoldColumn(false)]
            object fechacreacion { get; set; }
        }
        public interface itb_lugar_voto
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

        public interface itb_lugar_voto
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