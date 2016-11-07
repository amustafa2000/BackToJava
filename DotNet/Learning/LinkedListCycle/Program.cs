using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListCycle
{
	class Program
	{
		static void Main(string[] args)
		{
			Node node1 = new Node();
			node1.Data = 1;
			Node node2 = new Node();
			node2.Data = 2;
			Node node3 = new Node();
			node3.Data = 3;
			Node node4 = new Node();
			node4.Data = 4;
			Node node5 = new Node();
			node5.Data = 5;
			Node node6 = new Node();
			node6.Data = 6;
			Node node7 = new Node();
			node7.Data = 7;
			Node node8 = new Node();
			node8.Data = 8;
			node1.Next = node2;
			node2.Next = node3;
			node3.Next = node4;
			node4.Next = node5;
			node5.Next = node6;
			node6.Next = node7;
			node7.Next = node8;
			node8.Next = node1;

			Node fastNode = new Node();
			fastNode.Next = node1;
			Node slowNode = new Node();
			slowNode.Next = node1;
			bool cyclePresent = false;
			while (fastNode.Next != null && fastNode.Next.Next != null)
			{
				fastNode = fastNode.Next.Next;
				slowNode = slowNode.Next;
				if (fastNode.Next == slowNode.Next)
				{
					cyclePresent = true;
					break;
				}
			}
			Console.WriteLine(cyclePresent);
			Console.ReadKey();
		}
	}
	public class Node{
		private Node _next;
		private int _data;
		public Node()
		{
		}
		public int Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public Node Next
		{
			get
			{
				return this._next;
			}
			set
			{
				this._next = value;
			}
		}
	}
}
