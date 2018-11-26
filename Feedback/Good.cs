using System.ComponentModel.DataAnnotations.Schema;

namespace Feedback
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Обратная связь
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}