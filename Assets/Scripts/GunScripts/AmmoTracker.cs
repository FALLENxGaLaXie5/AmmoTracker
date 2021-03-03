using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AmmoTracker : MonoBehaviour
{
    int myGunNum = 1;
    public Text gunNum;
    Gun gun;
    private void Start()
    {
        loadGun();
    }

    public void setGunNumber(int newGunNum)
    {
        myGunNum = newGunNum;
    }
    public void setGunNumberText()
    {
        gunNum.text = "Gun: " + myGunNum;
    }
    void loadGun()
    {
        gun = new Gun();
    }

    public void trackingProjectile(int index)
    {
        gun.trackingProjectile(index);
    }
    public void trackingPropellant(int index)
    {
        gun.trackingPropellant(index);
    }
    public void trackingFuze(int index)
    {
        gun.trackingFuze(index);
    }

    public Gun GetGun()
    {
        return this.gun;
    }


    public void printAmmo()
    {
        print("Gun: " + myGunNum + "\n");
        foreach (Projectile projectile in gun.projectiles)
        {
            if (projectile.getUse())
            {
                print(projectile.printAmmo());
            }
        }
        foreach (Propellant propellant in gun.props)
        {
            if (propellant.getUse())
            {
                print(propellant.printAmmo());
            }
        }
        foreach (Fuze fuze in gun.fuzes)
        {
            if (fuze.getUse())
            {
                print(fuze.printAmmo());
            }
        }
    }
}