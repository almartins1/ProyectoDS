using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue
{
	static int N = 1;
	int[] arr = new int[N];
	int front, rear, count;
	public Queue(int tamaño)
	{
		N = tamaño;
		arr = new int[tamaño];
		front = 0;
	}

	public bool empty()
	{
		return count <= 0;
	}
	public bool full()
	{
		return count >= N;
	}
	public void enqueue(int item)
	{
		arr[rear] = item;
		rear = (rear + 1) % N;
		count++;
	}

	public int dequeue()
	{
		int item = arr[front];
		front = (front + 1) % N;
		count--;
		return item;
	}

}


