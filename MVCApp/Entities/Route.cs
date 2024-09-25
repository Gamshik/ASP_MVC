using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Route : EntityBase
    {
        public int Distance { get; set; }

        public int StartSettlementId { get; set; }
        public Settlement StartSettlement { get; set; }

        public int EndSettlementId { get; set; }
        public Settlement EndSettlement { get; set; }
    }
}
