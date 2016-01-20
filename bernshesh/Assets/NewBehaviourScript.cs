using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	int Class = 12;


	void Start () 
	{
		Class = MultiplyBy4 (Class);
		Debug.Log (Class);
	}


	int MultiplyBy4 (int number)
	{
		int ret;
		ret = number * 4;
		return ret;
	}
}
