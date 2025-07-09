using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataLayer.Entities
{
    internal class PostComment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int PostId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("PostId")]
        public Post Post { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
