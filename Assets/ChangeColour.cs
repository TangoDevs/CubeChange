using UnityEngine;
using System.Collections;

public class ChangeColour : MonoBehaviour {

    public ColourChange cg;

    private string name;

	// Use this for initialization
	void Start () {
	
        //set all to black

	}



    void OnMouseDown()
    {
        //get plane that was clicked 
        
        //raycast

        //get colour from cube 
        int selectedIndex=cg.GetColour();

        //change colour of plane 
        if (selectedIndex == 0)
        {
            //change colour plane to red
            Debug.Log("red");
            

        }
        else if (selectedIndex == 1)
        {
            //change colour plane to red
            Debug.Log("blue");
        }
        else if (selectedIndex == 2)
        {
            //change colour plane to red
            Debug.Log("green");
        }
    }
}
