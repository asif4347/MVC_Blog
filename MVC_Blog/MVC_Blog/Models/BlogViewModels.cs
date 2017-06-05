using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Blog.Models
{
    public class BlogViewModels
    {
    }
    public class post
    {
        public string Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="The {0} must be between {2} and {1} Characters long",MinimumLength =5)]
        [Display(Name ="Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "The {0} must be between {2} and {1} Characters long", MinimumLength = 10)]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "The {0} must be between {2} and {1} Characters long", MinimumLength = 30)]
        [Display(Name = "Body")]
        public string Body { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} Characters long", MinimumLength = 5)]
        [Display(Name = "Meta")]
        public string Meta { get; set; }

        [Required]
        [Display(Name ="URL SEO")]
        public string UrlSEO { get; set; }

        public bool  published { get; set; }
        [DefaultValue(0)]
        public int NetLikeCount { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }


    }

public class category
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "URL SEO")]
        public string  UrlSEO { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be between {2} and {1} Characters long", MinimumLength = 5)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public bool Checked { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
    }

    public class PostCategory
    {
        [Key]
        [Column(Order =0)]
        public string postId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string categoryId { get; set; }

        public bool Checked { get; set; }
        public post Post { get; set; }
        public category Category { get; set; }


    }

    public class comment
    {
        public string Id { get; set; }
        public string postId { get; set; }
        public DateTime dateTime { get; set; }
        public string UserName { get; set; }

        [Required]
        public string Body { get; set; }
        [DefaultValue(0)]
        public int NetLikesCount { get; set; }

        [DefaultValue(false)]
        public bool Deleted { get; set; }

        public post Post { get; set; }
        public ICollection<Reply> Replies { get; set; }
    }
}