using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    public int rows, columns;
    public ItemLorenz[] items;
    public Image[] images;
    Image[,] images2D;
    int c, currentRow, currentColumn;

    // Start is called before the first frame update
    void Start()
    {
        SetItemImages();
        Set2DArray();
    }


    void Update()
    {
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
        for(int i = 0; i < items.Length; i++)
        {
            images[i].sprite = items[i].image;
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
