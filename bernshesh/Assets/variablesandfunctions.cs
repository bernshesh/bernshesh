using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{   
	int myInt = 5;

			/*this is the variable. int is the type Of information this Variable will hold.
				myInt is the name Of the function, So that We can refer back To this Variable,
				And put it into our function.*/


	void Start ()

			/*void start basically is when the object that this script is attatched to begins its role in the
				game.*/
	{
		myInt = MultiplyByTwo(myInt);

			/*this is where we input the variable into the function.*/

		Debug.Log (myInt);
			
		/*debug is what lets us put the value of any variable into the game, in the parenthesis you can
				see that we Are putting in myInt.*/
	}


	int MultiplyByTwo (int number)

			/*this right here is the Function, we have the type as int, the name is MultiplyByTwo because
				that is what the function is going To do. In parenthesis We have the parameter type, int,
				and the name Of that parameter, number, so We Can put it into our return*/
			
	{
		int ret;
		ret = number * 2;
		return ret;

			/*down here is where We Are returning everything So that it shows in our game. as We are
				returning it We want it To multiply by two. So, the type is int, name is ret, short 
				for return. We put that ret is number - the name Of our parameter - times two. We then 
				return ret, putting it into our game. So, in summary, we take the value of the variable
				myInt and put that into our function. We then made the functions parameters make whatever
				variable we plug into our function return it multiplied by two.*/
	}
}