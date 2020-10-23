using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24hrSocial.Data
{
    public class Post
    {
        [key]
        public int PostId { get; set; }        
        public string Title { get; set; }
        public string Text { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string Id { get; set; }
        public virtual ApplicationUser User { get; set; }
     
   
    }
}
