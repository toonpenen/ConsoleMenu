using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuLib
{
    internal class OperationInfo
    {
        public InformationType MessageType { get; private set; }
        public string ResultantMessage { get; private set; }

        public OperationInfo(InformationType messageType, string resultantMessage)
        {
            MessageType = messageType;
            ResultantMessage = resultantMessage;
        }
    }
}
