using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{
    public List<Projectile> projectiles;
    public List<Propellant> props;
    public List<Fuze> fuzes;
    public Gun()
    {
        projectiles = new List<Projectile>();
        props = new List<Propellant>();
        fuzes = new List<Fuze>();
        projectiles.Add(new Projectile("M107", false, 0));
        projectiles.Add(new Projectile("M795", false, 0));
        projectiles.Add(new Projectile("M110", false, 0));
        projectiles.Add(new Projectile("M485A2", false, 0));
        projectiles.Add(new Projectile("M825", false, 0));
        projectiles.Add(new Projectile("M825A1", false, 0));
        projectiles.Add(new Projectile("M982A1", false, 0));

        props.Add(new Propellant("M231", false, 0));
        props.Add(new Propellant("M232A2", false, 0));

        fuzes.Add(new Fuze("M739A1", false, 0));
        fuzes.Add(new Fuze("M732A2", false, 0));
        fuzes.Add(new Fuze("M767", false, 0));
        fuzes.Add(new Fuze("M762", false, 0));
        fuzes.Add(new Fuze("M767A1", false, 0));
        fuzes.Add(new Fuze("M782", false, 0));

    }

    public void trackingProjectile(int index)
    {
        this.projectiles[index].setInUse(!(projectiles[index].getUse()));
    }
    public void trackingPropellant(int index)
    {
        this.props[index].setInUse(!(props[index].getUse()));
    }
    public void trackingFuze(int index)
    {
        this.fuzes[index].setInUse(!(fuzes[index].getUse()));
    }

    public void printAllAmmo()
    {
        for (int i = 0; i < projectiles.Count; i++)
        {
            if (this.projectiles[i].getUse())
            {
                Debug.Log(projectiles[i].getName() + ": " + projectiles[i].getNum());
            }
        }
        Debug.Log("\n");
        for (int i = 0; i < props.Count; i++)
        {
            if (this.props[i].getUse())
            {
                Debug.Log(props[i].getName() + ": " + props[i].getNum());
            }
        }
        Debug.Log("\n");

        for (int i = 0; i < fuzes.Count; i++)
        {
            if (this.fuzes[i].getUse())
            {
                Debug.Log(fuzes[i].getName() + ": " + fuzes[i].getNum());
            }
        }
    }
}
