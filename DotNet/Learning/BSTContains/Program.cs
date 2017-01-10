﻿using System;


/*
 * 
 * Binary search tree (BST) is a binary tree where the value of each node is larger 
 * or equal to the values in all the nodes in that node's left subtree 
 * and is smaller or equal than the values in all the nodes in that node's right subtree.
 * 
 * */
public class Node
{
	public int Value { get; set; }

	public Node Left { get; set; }

	public Node Right { get; set; }

	public Node(int value, Node left, Node right)
	{
		Value = value;
		Left = left;
		Right = right;
	}
}

public class BinarySearchTree
{
	public static bool Contains(Node root, int value)
	{
		if (root == null) return false;
		if(root.Value == value)
		{
			return true;
		}
		else if (root.Value < value)
		{
			return Contains(root.Right, value);
		}
		else
		{
			return Contains(root.Left, value);
		}
	}

	public static void Main(string[] args)
	{
		Node n1 = new Node(1, null, null);
		Node n3 = new Node(3, null, null);
		Node n2 = new Node(2, n1, n3);

		Console.WriteLine(Contains(n2, 11));
		Console.ReadKey();
	}
}