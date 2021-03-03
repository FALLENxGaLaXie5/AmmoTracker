using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Ammo
{
    protected string name;
    protected bool use;
    protected int num;
    
    public Ammo()
    {

    }
    public Ammo(string newName, bool newUse, int newNum)
    {
        name = newName;
        use = newUse;
        num = newNum;
    }

    public void setInUse(bool inUse)
    {
        use = inUse;
    }

    public void setNum(int newNum)
    {
        num = newNum;
    }

    public void addNum(int newNum)
    {
        num += newNum;
    }

    public void subtractNum(int newNum)
    {
        num -= newNum;
    }

    public string printAmmo()
    {
        return name + ": " + num + "\n";
    }

    

    public string getName() { return this.name; }
    public bool getUse() { return this.use; }
    public int getNum() { return this.num; }

}
