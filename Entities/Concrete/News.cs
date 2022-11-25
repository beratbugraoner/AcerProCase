using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class News : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string? Title { get; set; } = "defaultTitle";
        public string? Description { get; set; } = "defaultDescription";
        public bool? Status { get; set; } = false;
        public int CategoryId { get; set; }

    }
}
