using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasalyFlex.DAL.Entities.Identity;

namespace TasalyFlex.DAL.Entities
{
    public class UserCommentMovie : BaseEntity
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
