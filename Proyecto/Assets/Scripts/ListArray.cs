using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LArray
{
	static int N = 0;
	private int position, count;
	int[] larray = new int[N];
	public LArray(int tamano)
	{
		N = tamano + 1;
		count = 0;
		larray = new int[N];
	}
	private bool empty()
	{
		return count <= 0;
	}
	private bool full()
	{
		return count >= N;
	}
	public bool delete(int item)
	{
		MonoBehaviour.print(count + "Este es el primer count");
		bool deleted = false;
		if (!empty())
		{
			if (search(item))
			{
				for (int j = position; j < count - 1; j++)
				{
					larray[j] = larray[j + 1];
				}
				count--;
				MonoBehaviour.print("Se eliminó CORRECTAMENTE");
				MonoBehaviour.print(count + "Count fnnal");
				deleted = true;
			}
		}
		else
		{
			MonoBehaviour.print("Lista esta vacia");
		}
		return deleted;
	}
	public bool insert(int item)
	{
		bool inserted = false;
		if (!full())
		{
			if (!search(item))
			{
				for (int j = count; j > position; j--)
				{
					larray[j] = larray[j - 1];
				}
				larray[position] = item;
				count++;
				inserted = true;
			}
		}
		else
		{
			//imprimir("List is Full");
			MonoBehaviour.print("Lista esta llena");
		}
		return inserted;
	}
	public bool push(int item)
	{
		bool inserted = false;
		if (!full() && !empty())
		{
			larray[count + 1] = item;
			larray[position] = item;
			count++;
			inserted = true;
		}
		else if (empty())
		{
			larray[0] = item;
			count++;
		}
		else
		{
			MonoBehaviour.print("Lista esta llena");
		}
		return inserted;
	}

	public int pop()
	{
		//bool deleted = false;
		int dev = 0;
		if (!empty())
		{
			dev = larray[count];
			//larray[count] = null;
			count--;
			//deleted = true;
		}
		else
		{
			//imprimir("List is Empty");
			MonoBehaviour.print("Lista esta vacia");
		}
		return dev;
	}
	public int random()
	{
		int rand = Random.Range(0, N);
		int dev = larray[rand];
		return dev;
	}

	public bool search(int item)
	{
		bool found = false, stop = false;
		position = 0;
		while (position < count && !stop)
		{
			if (larray[position] == item)
			{
				stop = true;				
				found = true;
		
				
			}
			position++;
		}
		return found;
		}
		public void output()
		{
			MonoBehaviour.print("List: ");
			int j = 0;
			while (j != count)
			{
				MonoBehaviour.print(larray[j] + " ");
				j++;
			}
		}
}


