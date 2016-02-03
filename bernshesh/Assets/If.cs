using UnityEngine;
using System.Collections;

public class If : MonoBehaviour 
{
	public int cool = 10;

	void Start ()
	{
		if (cool > 0) {
			Debug.Log ("Too Small");
		} else if (cool < -10) {
			Debug.Log ("Really Small");
		} else {
			Debug.Log ("perfect");
		}
	}
}
