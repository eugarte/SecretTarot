using System;
using System.ComponentModel.DataAnnotations;
using SecretTarot.Infrastructure.Models;

namespace SecretTarot.Module.Search.Models
{
    public class Query : EntityBase
    {
        [Required]
        [StringLength(500)]
        public string QueryText { get; set; }

        public int ResultsCount { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
