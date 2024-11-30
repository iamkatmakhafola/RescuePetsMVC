using System.ComponentModel.DataAnnotations;

namespace u21503193_HW02.Models
{
    public class Adoption
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int PetId { get; set; }

        public DateTime AdoptionDate { get; set; }

        public int UseId { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
