using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    interface IOneWayLinkedListNode
    {
        IOneWayLinkedList List { get; }

        IOneWayLinkedListNode Next { get; }
    }
}
