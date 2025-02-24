using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PRIKOLY : MonoBehaviour
{
    public HardwareDataLoader.HardwareData hardwareDataToUse;
    void Start()
    {
        hardwareDataToUse = GetComponent<HardwareDataLoader>().GetHardwareData();
    }
}
