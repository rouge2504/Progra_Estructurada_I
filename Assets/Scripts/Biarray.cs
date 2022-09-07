using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Biarray : MonoBehaviour
{
    int[,] array = new int[4,2];
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = count;
                //print(array[i, j]);
                count++;

            }
        }

        print(array[2, 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
