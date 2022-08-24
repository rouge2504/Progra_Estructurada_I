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
        int counter = 0;
        while (!MakeAttack())
        {
            counter += 1;
        }
        print("Apenas salio despues de: " + counter + " intentos");
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
            
            print(medabot.nameMedabot + " is Legit: " + medabot.StatsLegit());
        }
    }

    bool MakeAttack()
    {
        int attack = 0;
        for (int i = 0; i < medabots[0].force; i++)
        {
            attack += Random.Range(1, 7); //1,2,3,4,5,6 //2,1,1,0,0,0
        }
        //print(attack);

        int def = 0;
        for (int i = 0; i < medabots[1].defense; i++)
        {
            def += Random.Range(1, 7);
        }
        //print(def);
        return attack > def;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
