using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcommerceStore.Domain.Entities
{
    public class EntityActionType
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(maximumLength:20)]
        public string ActionName { get; set; }
    }
}
