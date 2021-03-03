using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GunFieldInteraction : MonoBehaviour
{
    public InputField inputField;

    private int guns = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void changeGunAmount()
    {
        int textValue;
        int.TryParse(inputField.text, out textValue);
        guns = textValue;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public int GetNumberGuns()
    {
        return guns;
    }

}
