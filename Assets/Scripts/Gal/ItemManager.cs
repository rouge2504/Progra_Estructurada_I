using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Items[] items;
    int i = 0;

    private void Start()
    {
        items[i].select.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && i+1 < items.Length)
        {
            items[i].select.enabled = false;
            i++;
            items[i].select.enabled = true;
            Debug.Log(i);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && i + 1 >= items.Length)
        {
            items[i].select.enabled = false;
            i = 0;
            items[i].select.enabled = true;
            Debug.Log(i);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && i > 0)
        {
            items[i].select.enabled = false;
            i--;
            items[i].select.enabled = true;
            Debug.Log(i);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && i <= 0)
        {
            items[i].select.enabled = false;
            i = items.Length - 1;
            items[i].select.enabled = true;
            Debug.Log(i);
        }
    }
}
