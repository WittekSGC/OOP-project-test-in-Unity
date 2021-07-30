using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnglishCountry : Country
{ 
    public TextMeshPro outputHello;

    private void Start()
    {
        userName = MenuManager.Instance.UserName;
        Message = "Hello by USA for ";
        output = outputHello;
    }
}
