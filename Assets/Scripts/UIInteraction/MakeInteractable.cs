using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MakeInteractable : MonoBehaviour
{
    InputField inputField;
    AmmoTracker ammoTracker;
    private void Start()
    {
        inputField = this.gameObject.GetComponent(typeof(InputField)) as InputField;
        ammoTracker = this.gameObject.transform.parent.transform.parent.transform.parent.GetComponentInChildren<AmmoTracker>();        
    }
    public void changeFieldStatus()
    {
        bool i = inputField.interactable;
        inputField.interactable = !i;
        inputField.text = "";
    }



    public void changeInitialAmountProjectile(int i)
    {
        int textValue;
        int.TryParse(inputField.text, out textValue);
        ammoTracker.GetGun().projectiles[i].setNum(textValue);
    }

    public void changeInitialAmountPropellant(int i)
    {
        int textValue;
        int.TryParse(inputField.text, out textValue);
        ammoTracker.GetGun().props[i].setNum(textValue);
    }

    public void changeInitialAmountFuze(int i)
    {
        int textValue;
        int.TryParse(inputField.text, out textValue);
        ammoTracker.GetGun().fuzes[i].setNum(textValue);
    }
}
