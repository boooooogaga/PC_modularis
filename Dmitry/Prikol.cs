using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Prikol : MonoBehaviour
{
    public HardwareDataLoader.HardwareData data2Use;
    public string Oleg = "Tema";
    private IEnumerator Start() 
    {
        yield return new WaitForEndOfFrame();

        HardwareDataLoader loader = FindObjectOfType<HardwareDataLoader>();

        if (loader != null)
        {
            data2Use = loader.GetHardwareData();
        }
        for(int i = 0; i < data2Use.GPU.Length;  i++)
        {
            if (data2Use.GPU[i].model == Oleg)
            {
                Debug.Log("KRASAVA MARAT");
                
            }
            else
            {
                Debug.Log("ИДИ НАХУЙ");
            }
        }
        Debug.Log(data2Use.GPU[0].model);
    }

}
