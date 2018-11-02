﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Commands
{
    public class CommandResponse
    {
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? DeliveredAt { get; set; }

        public bool WasAccepted { get; set; }
    }
}
