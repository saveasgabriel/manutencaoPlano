using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ManutencaoPlano.Models
{
    public partial class FtAbateQuarteioHabilitacao
    {
        [DisplayName("Banco")]
        public string Cbd { get; set; }
        public DateTime? Dmovimento { get; set; }
        public int? Isequencial { get; set; }
    }
}
