﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }
}
 