using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }

}



public class ShopMenu : MonoBehaviour
{
    GameObject buttonTemplate;

    [Serializable]
    public struct Item
    {
        public string Name;
        public string Desc;
        public int Price;
        public Sprite Icon;
        public int itemID;
        public bool isPurchased;

        public Item(String name, String desc, int price, Sprite icon, int itemid)
        {
            Name = name;
            Desc = desc;
            Price = price;
            Icon = icon;
            itemID = itemid;
            isPurchased = false;
        }

        public String getName(int ID)
        {
            return null;
        }

        public String getDesc(int ID)
        {
            return null;
        }

        public Sprite getIcon(int ID)
        {
            return null;
        }

       /* public Item(int price, int itemid)
        {
            Name = getName(itemid);
            Desc = getDesc(itemid);
            Price = price;
            Icon = getIcon(itemid);
            itemID = itemid;
            isPurchased = false;
        }
        */
        
    }

    [SerializeField] Item[] allItems;



    void Start()
    {
        buttonTemplate = transform.GetChild(0).gameObject;

        initShop();
        buttonTemplate.SetActive(false);

    }

    void initShop()
    {
        int N = allItems.Length;

        for (int i = 0; i < N; i++)
        {
            if (allItems[i].isPurchased == false)
            {
                createButton(i);
            }
        }
        buttonTemplate.SetActive(false);

    }


    void buyItem(int i)
    {
        //if (player.currency >= item.price)
        //   {
        //    player.currency -= item.price;
        //  inventory.addItem(item);
        allItems[i].isPurchased = true;
        //   }
        refreshShop();
    }

    void refreshShop()
    {
        foreach (Transform child in transform)
        {
            if (child.transform.GetChild(1).GetComponent<Text>().text != "Template")
                GameObject.Destroy(child.gameObject);
        }
        buttonTemplate.SetActive(true);
        initShop();

    }

    void createButton(int n)
    {
        GameObject g;
        g = Instantiate(buttonTemplate, transform);
        g.transform.GetChild(0).GetComponent<Image>().sprite = allItems[n].Icon;
        g.transform.GetChild(1).GetComponent<Text>().text = allItems[n].Name;
        g.transform.GetChild(2).GetComponent<Text>().text = allItems[n].Desc;
        g.transform.GetChild(3).GetComponent<Text>().text = (allItems[n].Price).ToString();

        /*g.GetComponent<Button>().onClick.AddListener(delegate ()
       {
           ItemClicked(i);
       });
       */
        g.GetComponent<Button>().AddEventListener(n, ItemClicked);
    }



    void addItem(Item item)
    {
        allItems.SetValue(item, allItems.Length);
    }



    void ItemClicked(int itemIndex)
    {
        buyItem(itemIndex);
    }


}
