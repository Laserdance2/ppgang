using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dashbar : MonoBehaviour
{

    public Slider slider_1;
    public Slider slider_2;
    public Slider slider_3;

    // Start is called before the first frame update
    void Start()
    {
        slider_1.maxValue = 1;
        slider_2.maxValue = 1;
        slider_3.maxValue = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDash(float dash)
    {
        slider_1.value = dash;
        slider_2.value = dash - 1;
        slider_3.value = dash - 2;
    }
        
        
        
         

    
}
