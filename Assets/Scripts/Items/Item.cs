﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{


	new public string name = "New Item";
	public string description;
	public int price; 
	public Sprite sprite = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public virtual void Use(){
    	//use the item

    	Debug.Log("Using " +  name);
    }
}
