using System.Collections.Generic;

namespace Feedback
{
    public class Category
    {
        // Первичный ключ
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Good> Goods { get; set; }
    }
}