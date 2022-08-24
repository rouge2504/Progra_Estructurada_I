using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    Inventory inventory;
     public Image image;

    Items [] container;

    void Start()
    {
        //RectTransform selectPosition = image.gameObject.GetComponent<RectTransform>();
        //Debug.Log(inventory.itemInventory[2].name);
        //inventory = gameObject.GetComponent<Inventory>();
        //for(int i = 0; i < inventory.itemInventory.Length; i++)
        //{
        //    container[i] = inventory.itemInventory[i];
        //    Debug.Log(i);

        //}

        RectTransform picture = image.GetComponent<RectTransform>();
        //picture.anchoredPosition = new Vector2(inventory.itemInventory[3].GetComponent<RectTransform>().position.x, inventory.itemInventory[3].GetComponent<RectTransform>().position.y);


    }

    void Update()
    {
       
       
    }


}
