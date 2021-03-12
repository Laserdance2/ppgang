using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShopMenu : MonoBehaviour
{
    [Serializable]
    public struct Item
    {
        public string Name;
        public string Desc;
        public int Price;
        public Sprite Icon;

    }

    [SerializeField] Item[] allItems;

    

    void Start()
    {
        GameObject buttonTemplate = transform.GetChild (0).gameObject;
        GameObject g;

        int N = allItems.Length;

        for (int i = 0; i < N; i++)
        {
            g = Instantiate(buttonTemplate, transform);
            g.transform.GetChild(0).GetComponent<Image>().sprite = allItems[i].Icon;
            g.transform.GetChild (1).GetComponent <Text> ().text = allItems[i].Name;
            g.transform.GetChild(2).GetComponent<Text>().text = allItems[i].Name;
        }

        Destroy(buttonTemplate);
    }
}
