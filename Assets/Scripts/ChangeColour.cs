using UnityEngine;
using System.Collections;


public class ChangeColour : MonoBehaviour {

    public ColourChange cg;

    private string name;
    Renderer myRenderer;
    GameObject g1;

	// Use this for initialization
	void Start () {
	
        //set all to black
         myRenderer = gameObject.GetComponent<Renderer>();
        myRenderer.material.color = new Color(0,0,0,1);
	}




    void OnMouseDown()
    {
       
        //get plane that was clicked 
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
           g1= hit.transform.gameObject;
        }
        //raycast
        g1 = hit.transform.gameObject;
        //get colour from cube 
        int selectedIndex=cg.GetColour();
        myRenderer = g1.gameObject.GetComponent<Renderer>();

        //change colour of plane 
        if (selectedIndex == 0)
        {
            //change colour plane to red
            //Debug.Log("red");
            
            myRenderer.material.color = new Color(1, 0, 0, 1);

        }
        else if (selectedIndex == 1)
        {
            //change colour plane to red
            //Debug.Log("blue");
            myRenderer.material.color = new Color(0, 0, 1, 1);
        }
        else if (selectedIndex == 2)
        {
            //change colour plane to red
            //Debug.Log("green");
            myRenderer.material.color = new Color(0, 1, 0, 1);
        }
    }
}
