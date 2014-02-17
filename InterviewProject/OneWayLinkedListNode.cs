using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public class OneWayLinkedListNode
    {
        public OneWayLinkedListNode(int value, OneWayLinkedListNode next)
        {
            Value = value;
            Next = next;
        }

        public OneWayLinkedListNode Next { get; private set; }

        public int Value { get; private set;  }
    }
}
