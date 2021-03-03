using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fuze : Ammo
{
    public Fuze(string newName, bool newUse, int newNum)
    {
        name = newName;
        use = newUse;
        num = newNum;
    }
}
