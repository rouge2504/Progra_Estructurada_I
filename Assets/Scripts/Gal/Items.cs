using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public Sprite sprite;
    public string description;
    public int health;
    public Image image;
    public Image select;

    private void Start()
    {
       image.sprite = sprite;
       //select.GetComponent<Image>().enabled = false;
    }

}
