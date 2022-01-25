using System;
using System.ComponentModel.DataAnnotations;

namespace EF.Common
{
    public abstract class EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
