﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour {

   public Dropdown myDropdown;
    int selectedindex;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    
        //get drop down list selected index
       selectedindex= myDropdown.value;
      
	}

    public  int GetColour()
    {
        //return colour 
        int selected = selectedindex;
        return selected;
    }
}