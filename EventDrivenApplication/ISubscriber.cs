using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenApplication
{
    internal interface ISubscriber
    {
        void HandleSystemUpdate(string message, DateTime time);
        void HandleSecurityAlert(string message, DateTime time);
        void HandleWelcomeMessage(string message, DateTime time);
    }
}

