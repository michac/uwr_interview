using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public interface IOneWayLinkedList
    {
        IOneWayLinkedListNode First { get; }

        void AddLast(int value);

        void AddFirst(int value);

        List<int> ToList();

        int Count { get; }
    }
}
