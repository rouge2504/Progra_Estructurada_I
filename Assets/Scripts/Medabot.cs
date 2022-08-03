using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Create Medabot", menuName = "Medabot")]
public class Medabot : ScriptableObject
{
    public enum ELEMENT { NONE, FIRE, GRASS, WATER, ELECTRIC, WIND, LIGHT, DARK}

    public int velocity;
    public int life;
    public int force;
    public int energy;
    public int defense;
    public int stamina;

    public ELEMENT element = ELEMENT.NONE;
}
