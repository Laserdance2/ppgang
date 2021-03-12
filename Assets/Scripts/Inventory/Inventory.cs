using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    void Awake(){
    	if(instance != null){
    		Debug.LogWarning("OOeps meerder inventarisen blijkbaar"); 
    		return;
    	}
    	instance = this; 
    }

 
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20; 

	public List<Item> items = new List<Item>();

	public bool Add(Item item){
		// mss voeg iets toe met not default item, maar dat bleek tot nu toe niet noodzakelijk
		if(items.Count < space){
			items.Add(item); 
			if(onItemChangedCallback != null){
				onItemChangedCallback.Invoke();
			}
		}else{
			Debug.Log("Onvoldoende ruimte in inventaris");
			return false;
		}
		return true; 
	}

	public void Remove(Item item){
		items.Remove(item);
		if(onItemChangedCallback != null){
				onItemChangedCallback.Invoke();
		}
	}

}
