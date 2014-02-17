using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    /// <summary>
    /// Interface for a one-way forward linked list. Implementations should
    /// only hold a reference to the first node in the list, then each node has
    /// a reference to the next node.
    /// </summary>
    public interface IOneWayLinkedList
    {
        OneWayLinkedListNode First { get; }

        /// <summary>
        /// Insert a value to the end of the list.
        /// </summary>
        /// <param name="value"></param>
        void InsertLast(int value);

        /// <summary>
        /// Insert a value to the beginning of the list.
        /// </summary>
        /// <param name="value"></param>
        void InsertFirst(int value);

        /// <summary>
        /// Convert the linked list to a generic .NET List.
        /// </summary>
        /// <returns></returns>
        List<int> ToFrameworkList();

        /// <summary>
        /// Return a count of the number of items in the list.
        /// </summary>
        int Count { get; }
    }
}
