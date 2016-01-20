using UnityEngine;
using System.Collections;

public class bernshesh : MonoBehaviour {
	int Class = 12;


	void Start () 
	{
		Class = MultiplyByTwo (Class);
			Debug.Log (Class);
	}
	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
