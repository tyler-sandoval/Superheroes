using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes.EF.DATA//.Metadata
{
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course { }

    class CourseMetadata
    {
        [Required(ErrorMessage = "* Course Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "* All courses require a course description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* Must select a type")]
        public int TypeID { get; set; }

        [Required(ErrorMessage = "* Must have a date for course")]
        public System.DateTime Date { get; set; }
    }
}
