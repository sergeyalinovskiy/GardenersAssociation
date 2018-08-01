using System.ComponentModel.DataAnnotations;

namespace SA.GA.Common.Models
{
    public abstract class Entity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
