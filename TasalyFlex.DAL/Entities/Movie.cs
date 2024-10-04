using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasalyFlex.DAL.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
