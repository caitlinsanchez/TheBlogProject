using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AuthorId { get; set; }
        public int ModeratorId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "{0} must be at least {2} characters long and at most {1} characters.", MinimumLength = 2)]
        [Display(Name = "Comment")]

        public int Body { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }
        [Display(Name = "Moderated Date")]
        public DateTime? Moderated { get; set; }
        [Display(Name = "Moderated Date")]
        public DateTime? Deleted { get; set; }

        [StringLength(500, ErrorMessage = "{0} must be at least {2} characters long and at most {1} characters.", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; }

        //Navigation properties

        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }
        public virtual IdentityUser Moderator { get; set; }

    }
}
