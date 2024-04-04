namespace BMSClone.Models
{
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MovieLanguage> MovieLanguages { get; set; }
    }
}
