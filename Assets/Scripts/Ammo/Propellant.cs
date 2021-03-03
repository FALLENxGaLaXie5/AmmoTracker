using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Propellant : Ammo
{
    public Propellant(string newName, bool newUse, int newNum)
    {
        name = newName;
        use = newUse;
        num = newNum;
    }
}
