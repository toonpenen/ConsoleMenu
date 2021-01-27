using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuLib
{
        public class ConsoleMenuReport
        {
            private string buffer;
            public string CreatorName { get; private set; }
            public DateTime ReportCreationTime { get; private set; }
            
            public string DynamicMessage { get; private set; }
            
            public string StaticMessage
            {
                get
                {
                    if (UpdateStaticMessageRequest) return buffer;
                    else return "";
                }
            }
            public Request InterruptionRequest { get; private set; }
            
            public bool UpdateStaticMessageRequest { get; private set; }

            public ConsoleMenuReport(string reportCreatorName = "NOT_DEFINED", Request interruptionRequest = Request.WithoutInterruption)
            {
                buffer = "";
                CreatorName = reportCreatorName;
                ReportCreationTime = DateTime.Now;
                DynamicMessage = "";
                InterruptionRequest = interruptionRequest;
                UpdateStaticMessageRequest = false;
            }
            public ConsoleMenuReport(string userMessage, string reportCreatorName = "NOT_DEFINED", Request interruptionRequest = Request.WithoutInterruption)
            {
                buffer = "";
                CreatorName = reportCreatorName;
                ReportCreationTime = DateTime.Now;
                DynamicMessage = userMessage;
                InterruptionRequest = interruptionRequest;
                UpdateStaticMessageRequest = false;
            }          
            public ConsoleMenuReport(string statusMessage, string userMessage, string reportCreatorName = "NOT_DEFINED", Request interruptionRequest = Request.WithoutInterruption)
            {
                buffer = statusMessage;
                CreatorName = reportCreatorName;
                ReportCreationTime = DateTime.Now;
                UpdateStaticMessageRequest = true;
                DynamicMessage = userMessage;
                InterruptionRequest = interruptionRequest;
            }
        }
    }


