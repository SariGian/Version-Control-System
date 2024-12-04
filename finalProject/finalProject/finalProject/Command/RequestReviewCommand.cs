using FinalProject.Composite;
using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command
{
    internal class RequestReviewCommand : systemItemCommand
    {
        public RequestReviewCommand(SystemItem systemItem) : base(systemItem)
        {
        }

        public override string Execute()
        {
           return SystemItem.ReqestReview();
        }
    }
}
