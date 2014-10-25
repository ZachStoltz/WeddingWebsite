using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WeddingWebsite.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Comment")]
        public string Text { get; set; }
        [Required]
        [Display(Name="Song Request")]
        public string SongRequest { get; set; }
        public DateTime TimeStamp { get; set; }

        //This is used for whenever you loop through the list of comments in the DB when using this class as the model of both display and Input.
        public IEnumerable<Comment> Comments { get; set; }
    }
}
