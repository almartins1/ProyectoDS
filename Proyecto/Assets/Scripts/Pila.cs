using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila
{
	static int cantidad;
	int[] arr = new int[cantidad];
	int pos = 0;

	public Pila(int tamaño)
	{
		arr = new int[tamaño];
	}

	public void push(int num)
	{
		arr[pos] = num;
		pos++;
	}

	public int pop()
	{
		pos = pos - 1;
		return arr[pos];
	}

	public bool full()
	{
		return pos == cantidad;
	}

	public bool empty()
	{
		return pos == 0;
	}

}
