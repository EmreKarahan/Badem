using System;
using System.Collections.Generic;

namespace Bade.ModelGenerator.Models
{
    public partial class AdminRole
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public short RoleId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Role Role { get; set; }
    }
}
