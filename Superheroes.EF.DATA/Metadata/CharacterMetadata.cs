using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.EF.DATA//.Metadata
{
    [MetadataType(typeof(CharacterMetadata))]
    public partial class Character{ }

    public class CharacterMetadata
    {
        [StringLength(100, ErrorMessage = "* Hero/Villain name cannot exceed 100 characters")]
        [Required(ErrorMessage = "* Hero/Villain must have a name")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "* Alias cannot exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Alias { get; set; }

        [StringLength(30, ErrorMessage = "* Race cannot exceed 30 characters")]
        [DisplayFormat(NullDisplayText = "-")]
        public string Race { get; set; }

        [StringLength(100, ErrorMessage = "* Occupation cannot exceed 100 characters")]
        public string Occupation { get; set; }

        [StringLength(50, ErrorMessage = "* Ability cannot exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Ability 1")]
        public string AbilityOne { get; set; }

        [StringLength(50, ErrorMessage = "* Ability cannot exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Ability 2")]
        public string AbilityTwo { get; set; }

        [StringLength(50, ErrorMessage = "* Ability cannot exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "-")]
        [Display(Name = "Ability 3")]
        public string AbilityThree { get; set; }

        
        public string Image { get; set; }

        [Display(Name = "Alignment")]
        public Nullable<int> AlignID { get; set; }
    }
}
