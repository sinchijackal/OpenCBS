﻿namespace Octopus.CoreDomain.Events.Teller
{
    public class TellerCashInEvent : TellerEvent
    {
        public override string Code
        {
            get { return "TCIE"; }
            set { }
        }
    }
}