using BMSClone.Models;

namespace BMSClone.DTOs
{
    public class ShowDTO
    {
      
        public string Name { get; set; }

        public string start { get; set; }

        public int duration { get; set; }
        public int MovieId { get; set; }
        public int theatreId { get; set; }

        public int hallid { get; set; }
    }
}
