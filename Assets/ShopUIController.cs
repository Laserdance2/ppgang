using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ShopUIController : MonoBehaviour
{
    bool toggle = true;
    GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = transform.GetChild(0).gameObject;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            shopToggle();
        }
    }

    public void shopToggle()
    {
        if (toggle)
        {
            canvas.SetActive(true);
            toggle = false;
        }
        else
        {
            canvas.SetActive(false);
            toggle = true;
        }
    }
}
