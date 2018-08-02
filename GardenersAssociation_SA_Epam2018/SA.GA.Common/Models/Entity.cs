namespace SA.GA.Common.Models
{
    #region Usings
    using System.ComponentModel.DataAnnotations;
    #endregion
    public abstract class Entity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
