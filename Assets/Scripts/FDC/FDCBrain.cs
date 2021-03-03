using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FDCBrain : MonoBehaviour
{
    [SerializeField] GameObject gunCanvas;
    [SerializeField] GameObject gunPrefab;

    [SerializeField] List<Transform> gunRectPositions;

    public List<GameObject> gunsObjects = new List<GameObject>();
    List<Gun> guns = new List<Gun>();
    GunFieldInteraction gunsField;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateGunFields();
    }

    void InstantiateGunFields()
    {
        gunsField = GameObject.FindGameObjectWithTag("GunCreation").GetComponent<GunFieldInteraction>();
        GameObject currentCreatedGun;
        for (int i = 0; i < gunsField.GetNumberGuns(); i++)
        {
            currentCreatedGun = Instantiate(gunPrefab, new Vector3(gunRectPositions[i].position.x, gunRectPositions[i].position.y, gunRectPositions[i].position.z), Quaternion.identity);
            currentCreatedGun.transform.SetParent(gunRectPositions[i]);
            AssignGunNumbers(currentCreatedGun, i);
            gunsObjects.Add(currentCreatedGun);
        }
    }

    void AssignGunNumbers(GameObject currentCreatedGun, int i)
    {
        foreach (Transform child in currentCreatedGun.transform)
        {
            if (child.tag == "GunNumberText")
            {
                child.GetComponent<Text>().text = "Gun " + (i + 1);
            }

            if (child.tag == "AmmoTracker")
            {
                child.GetComponent<AmmoTracker>().setGunNumber(i + 1);
            }
        }
    }

    public void processMissions()
    {
        foreach (GameObject gunObject in gunsObjects)
        {
            guns.Add(gunObject.GetComponentInChildren<AmmoTracker>().GetGun());
        }        
    }
}
