using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Attack
{
    public enum ATTACK_TYPE { NONE, PHYSIC, ENERGY};

    public string nameAttack;
    public string description;
    public ATTACK_TYPE type = ATTACK_TYPE.NONE;
    public int damage;
    public int energyCost;

}
