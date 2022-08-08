using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [SerializeField] private string[] contentDialogue;
    public TextMeshProUGUI dialogue;

    public float timeToErase = 5;
    public float timingToErase;
    void Start()
    {
        dialogue.text = Next();
    }


    public void NextDialogue()
    {
        print("Estoy apretando esto");
        dialogue.text = Next();
    }

    public void FixedUpdate()
    {
       
        timingToErase += Time.deltaTime;
        if (timingToErase > timeToErase)
        {
            dialogue.text = Next();
            timingToErase = 0;
        }
    }

    public void Update()
    {
        
    }

    public string Next()
    {
        string dialogue = contentDialogue[0];
        string[] contentDialogue_temp = new string[contentDialogue.Length - 1];

        for (int i = 1; i < contentDialogue.Length; i++)
        {
            int it_temp = i - 1;
            contentDialogue_temp[it_temp] = contentDialogue[i];
        }
        contentDialogue = new string[contentDialogue_temp.Length];

        for (int i = 0; i < contentDialogue_temp.Length; i++)
        {
            contentDialogue[i] = contentDialogue_temp[i];
        }
        return dialogue;
    }
}
