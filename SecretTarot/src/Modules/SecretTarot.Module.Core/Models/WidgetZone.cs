﻿using SecretTarot.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Core.Models
{
    public class WidgetZone : EntityBase
    {
        public WidgetZone(long id)
        {
            Id = id;
        }

        [Required]
        [StringLength(450)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
