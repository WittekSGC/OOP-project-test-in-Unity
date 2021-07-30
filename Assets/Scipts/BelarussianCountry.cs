using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BelarussianCountry : Country
{
    private new string Message { get; set; } = "����i����� � �������i �� ";

    public TextMeshPro outputHello;

    private void Start()
    {
        userName = MenuManager.Instance.UserName;
        output = outputHello;
    }

    public override void SayHello()
    {
        output.text = Message + userName + "!";
    }
}
