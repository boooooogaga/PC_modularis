using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public void Allo()
    {
        Debug.Log(dropdown.options[dropdown.value].text);
    }
}
