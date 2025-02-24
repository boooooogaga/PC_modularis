using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prikol : MonoBehaviour
{
    private FlexComponent flexC;
    public HardwareDataLoader.HardwareData data2Use;

    private IEnumerator Start() 
    {
        yield return new WaitForEndOfFrame();

        HardwareDataLoader loader = FindObjectOfType<HardwareDataLoader>();

        if (loader != null)
        {
            data2Use = loader.GetHardwareData();
        }
    }
}
