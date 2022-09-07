using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystemLorenz : MonoBehaviour
{
    [SerializeField] private string[] contentDialogue;
    public TextMeshProUGUI dialogue;

    void Start()
    {
        StartCoroutine(NextDialogue());
    }


   public void StartDialogue()
   {
        for(int i = 0; i < contentDialogue.Length; i++)
        {
            StartCoroutine(NextDialogue());
            print("COSO");
        }
   }

    IEnumerator NextDialogue()
    {
        int originalLenght = contentDialogue.Length;

        for (int i = 0; i < originalLenght; i++)
        {
            dialogue.text = Next();
            yield return new WaitForSeconds(5f);
        }
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
