using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Node node1 = new Node(2);
			node1.AddToEnd(3);
			node1.AddToEnd(33);
			node1.Print();
			 * */
			/*MyList myList = new MyList();
			myList.AddToTheEnd(2);
			myList.AddToTheEnd(3);
			myList.AddToTheEnd(33);
			myList.AddToBegining(0);
			 * */
			MyList myList = new MyList();
			myList.AddSorted(2);
			myList.AddSorted(31);
			myList.AddSorted(33);
			myList.AddSorted(33);
			myList.AddSorted(23);
			myList.AddSorted(13);
			myList.AddSorted(3);
			myList.AddSorted(3);
			myList.Print();
			RemoveDuplicate(myList);
			Console.WriteLine("Removing duplicates");
			myList.Print();
			Console.ReadKey();
		}
		static void RemoveDuplicate(MyList myList)
		{
			Node node = myList.headNode;
			while (node.next != null)
			{
				if (node.data == node.next.data)
				{
					node.next = node.next.next;
				}
				else
				{
					node = node.next;
				}
			}
		}

	}
	public class MyList
	{
		public Node headNode;
		public MyList()
		{
			headNode = null;
		}
		public void AddToTheEnd(int data)
		{
			if (headNode == null)
			{
				this.headNode = new Node(data);
			}
			else
			{
				headNode.AddToEnd(data);
			}
		}
		public void AddToBegining(int data)
		{
			if (headNode != null)
			{
				Node newheadNode = new Node(data);
				newheadNode.next = headNode;
				headNode = newheadNode;
			}
			else
			{
				this.AddToTheEnd(data);
			}
		}
		public void AddSorted(int data)
		{
			if (headNode == null)
			{
				headNode = new Node(data);
			}
			else if (data < headNode.data)
			{
				AddToBegining(data);
			}
			else
			{
				headNode.AddSorted(data);
			}
		}
		public void Print()
		{
			if (headNode != null)
			{
				headNode.Print();
			}
		}
	}
	public class Node
	{
		public int data;
		public Node next;
		public Node(int data)
		{
			this.data = data;
			this.next = null;
		}
		public void SetNext(Node next)
		{
			this.next = next;
		}
		public void Print()
		{
			Console.Write(this.data+"->");
			if (this.next != null)
			{
				this.next.Print();
			}
		}
		public void AddToEnd(int data)
		{
			if (next == null)
			{
				next = new Node(data);
			}
			else
			{
				next.AddToEnd(data);
			}
		}
		public void AddSorted(int data)
		{
			if (next == null)
			{
				next = new Node(data);
			}
			else if (data < next.data)
			{
				Node temp = new Node(data);
				temp.next = this.next;
				this.next = temp;
			}
			else
			{
				next.AddSorted(data);
			}
		}
	}
}
