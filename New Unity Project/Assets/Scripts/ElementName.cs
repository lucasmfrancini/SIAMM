﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ElementName : MonoBehaviour
{
    private TextMeshProUGUI elementName;

    //cambiar lo que dice el label
    public void ChangeElement(string name)
    {
        Debug.Log(name);
        Debug.Log(elementName.text);
        elementName.SetText(name);
    }
}
