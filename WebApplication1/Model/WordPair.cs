using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class WordPair
    {
        [Key]
        public int Id { get; set; }
        public string EnglishWord { get; set; }
        public string ArabicWord { get; set; }
        [ForeignKey("CategoryId")] public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
