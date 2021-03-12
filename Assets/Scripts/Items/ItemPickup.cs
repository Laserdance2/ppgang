using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

	public Item item;


	public void Interact(){
		Debug.Log("Interacting with " + transform.name);
		PickUp();

	}

	void PickUp(){

		Debug.Log("Picking up item " + item.name); 
 
		bool wasPickedUp = Inventory.instance.Add(item);
		if(wasPickedUp){
			Destroy(gameObject); 
		}

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            PickUp();
        }
    }


    // Update is called once per frame
    void Update ()
	{

	}
}
