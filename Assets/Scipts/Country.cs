using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Country : MonoBehaviour
{
    protected string Message { get; set; } = "Hello by Not existing country for ";
    protected string userName { get; set; } = "unknown user";
    protected TextMeshPro output;

    public virtual void SayHello()
    {
        output.text = Message + userName + "!";
    }

    private void OnMouseDown()
    {
        RaycastHit hit;
        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
        if (hit.transform.gameObject.CompareTag("Country"))
        {
            SayHello();
        }
    }
}
