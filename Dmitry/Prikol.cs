using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Prikol : MonoBehaviour
{
    public HardwareDataLoader.HardwareData data2Use;
    public string Oleg = "Tema";
    public bool GPUCoop = false;
    public bool CPUCoop = false;
    public bool RAMCoop = false;
    public bool CaseCoop = false;
    public bool CoolerCoop = true;
    public string CurrentSocket;
    public string CurrentChipset;
    public string CurrentRAMslot;
    public string CurrentCaseSlot;
    public string CurrentGPUsocket;
    public string CurrentCPUsocket;
    public string CurrentRAMtype;
    public string CurrentCasetype;
    public string CurrentCoolertype;
    public static Prikol prikol;

    private IEnumerator Start()
    {
        prikol = this;
        yield return new WaitForEndOfFrame();  // Задержка на один кадр, если нужно

        // Поиск HardwareDataLoader в сцене
        HardwareDataLoader loader = FindObjectOfType<HardwareDataLoader>();

        // Проверка, если HardwareDataLoader не найден
        if (loader == null)
        {
            Debug.LogError("HardwareDataLoader not found!");
        }
        else
        {
            Debug.Log("HardwareDataLoader found.");
            data2Use = loader.GetHardwareData();

            // Проверка, если данные не загружены
            if (data2Use == null)
            {
                Debug.LogError("Failed to load hardware data.");
            }
        }
    }
    public void GPUCOOP()
    {
        if(CurrentGPUsocket == CurrentSocket)
        {
            GPUCoop = true;
        }
    }
    public void CPUCOOP()
    {
        if (CurrentCPUsocket == CurrentChipset)
        {
            CPUCoop = true;
        }
    }
    public void RAMCOOP()
    {
        if (CurrentRAMslot == CurrentRAMtype)
        {
            RAMCoop = true;
        }
    }
    public void CaseCOOP()
    {
        if(CurrentCasetype == CurrentCaseSlot)
        {
            CaseCoop = true;
        }
    }
    
}
