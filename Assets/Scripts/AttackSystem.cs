using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] private Medabot medabot1;
    [SerializeField] private Medabot medabot2;

    private List<Medabot> medabots;
    // Start is called before the first frame update
    void Start()
    {
        InitBattle();
    }

    void InitBattle()
    {
        medabots = new List<Medabot>();

        if (medabot1.velocity > medabot2.velocity)
        {
            medabots.Add(medabot1);
            medabots.Add(medabot2);

        }
        else
        {
            medabots.Add(medabot2);
            medabots.Add(medabot1);
        }


        foreach (Medabot medabot in medabots)
        {
            print(medabot.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
