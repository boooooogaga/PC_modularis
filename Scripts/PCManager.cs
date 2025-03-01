using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCManager : MonoBehaviour
{
    [SerializeField] GameObject CPU;
    [SerializeField] GameObject GPU;
    [SerializeField] GameObject Case;
    void Start()
    {
        if(PlayerPrefs.GetInt("CPUCoop") == 1)
        {
            CPU.SetActive(true);
        }
        else CPU.SetActive(false);
        if (PlayerPrefs.GetInt("GPUCoop") == 1)
        {
            GPU.SetActive(true);
        }
        else GPU.SetActive(false);
        if (PlayerPrefs.GetInt("CaseCoop") == 1)
        {
            Case.SetActive(true);
        }
        else Case.SetActive(false);
    }
}
