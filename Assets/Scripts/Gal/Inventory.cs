using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public int rows, columns;
    public Items[] items;
    public Image[] images;
    Image[,] images2D;
    int c, currentRow, currentColumn;

   //public Items [] itemInventory;


    [SerializeField]
    private RectTransform contentPanel; 
   // public static int [,] inventory = new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };
   // static int rows = inventory.GetLength(0);
    //static int columns = inventory.GetLength(1);
    //static int x=0;
    //static int y = 0;
   
    
  
    void Start()
    {
        Debug.Log(itemInventory[1].name);
        //var itemsChild = GameObject.Find("Items").transform;
        //Debug.Log(itemsChild.name);

        //foreach (Items items in Object.FindObjectsOfType<Items>())
        //    itemInventory = new Items[i];
        //    i++;
        SetItemImages();
        Set2DArray();
    }

    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    Debug.Log(inventory[y, x].ToString());
        //    if(x<rows) x++;
        //       // Debug.Log(inventory[0,i].ToString());
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    Debug.Log(inventory[y, x].ToString());
        //    if (x != 0) x--;
        //    // Debug.Log(inventory[0,i].ToString());
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    Debug.Log(inventory[y, x].ToString());
        //    if (y == 0) y++;
        //    // Debug.Log(inventory[0,i].ToString());
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    Debug.Log(inventory[y, x].ToString());
        //    if (y == 1) y--;
        //    // Debug.Log(inventory[0,i].ToString());
        //}
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            currentRow--;
        }//Moverse una fila para arriba

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            currentRow++;
        }//Moverse una fila para abajo

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            currentColumn++;
        }//Moverse una columna para la derecha

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            currentColumn--;
        }//Moverse una columna para la izquierda

        SetItemImages();
        Set2DArray();
        images2D[currentRow, currentColumn].sprite = null;

    }

    void SetItemImages()
    {
        for (int i = 0; i < items.Length; i++)
        {
            images[i].sprite = items[i].sprite;
        }
    }

    void Set2DArray()
    {
        images2D = new Image[rows, columns];


        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < columns; k++)
            {
                images2D[i, k] = images[c];
                c++;
            }//Iterar columnas
        }//Iterar fila

        c = 0;
    }

}
