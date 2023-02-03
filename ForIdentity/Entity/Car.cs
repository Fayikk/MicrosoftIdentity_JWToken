using System.ComponentModel.DataAnnotations;

namespace ForIdentity.Entity
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }   
        public string ModelYear { get; set; }

    }
}
