using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (LinkedListNode<int> i = list.First; i != null; i = i.Next)
            {
                LinkedListNode<int> minNode = i;
                for (LinkedListNode<int> j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value < minNode.Value)
                    {
                        minNode = j;
                    }
                }

                if (minNode != i)
                {
                    int t = i.Value;
                    i.Value = minNode.Value;
                    minNode.Value = t;
                }
            }
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            for (LinkedListNode<int> i = list.First; i != null; i = i.Next)
            {
                LinkedListNode<int> maxNode = i;
                for (LinkedListNode<int> j = i.Next; j != null; j = j.Next)
                {
                    if (j.Value > maxNode.Value)
                    {
                        maxNode = j;
                    }
                }

                if (maxNode != i)
                {
                    int t = i.Value;
                    i.Value = maxNode.Value;
                    maxNode.Value = t;
                }
            }
            return list;
        }
    }
}
