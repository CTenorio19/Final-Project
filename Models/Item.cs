using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Products.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProductId {get;set;} = string.Empty;
        
        [Display (Name ="Item Name")]
        [Required(ErrorMessage =" Item Name!!!")]
        public String Disease{get;set;}

        [Display (Name ="Enter First Item")]
        [Required(ErrorMessage =" Item is Required!!!")]
        public String ItemOne{get;set;}
        
        [Display (Name ="Enter Second Item")]
        [Required(ErrorMessage =" Item is Required!!!")]
        public String ItemTwo{get;set;}
        [Display (Name ="Enter Third Item")]
        [Required(ErrorMessage =" Item is Required!!!")]
        public String ItemThree{get;set;}
        [Display (Name ="Enter Fourth Item")]
        [Required(ErrorMessage =" Item is Required!!!")]
        public String ItemFour{get;set;}
        [Display (Name ="Enter Fifth Item")]
        [Required(ErrorMessage =" Item is Required!!!")]
        public String ItemFive{get;set;}
    }
}