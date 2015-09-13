using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nuty.Authorization.Module {
    public class Controller {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
    }
}