using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Prikol : MonoBehaviour
{
    [SerializeField] public TMP_Text MotherVersion;
    [SerializeField] public TMP_Text compatibilityGPU;
    [SerializeField] public TMP_Text compatibilityCPU;
    [SerializeField] public TMP_Text compatibilityRAM;
    [SerializeField] public TMP_Text compatibilityCase;
    [SerializeField] public TMP_Text compatibilityCooler;
    public HardwareDataLoader.HardwareData data2Use;

    [SerializeField] public GameObject CoopPanel;

    public string Oleg = "Tema";
    public bool GPUCoop = false;
    public bool CPUCoop = false;
    public bool RAMCoop = false;
    public bool CaseCoop = false;
    public bool CoolerCoop = true;
    public string CurrentMother;
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
            compatibilityGPU.text = "true";
            compatibilityGPU.color = Color.green;
        }
        else
        {
            compatibilityGPU.text = "false";
            compatibilityGPU.color = Color.red;
        }
    }
    public void CPUCOOP()
    {
        if (CurrentCPUsocket == CurrentChipset)
        {
            CPUCoop = true;
            compatibilityCPU.text = "true";
            compatibilityCPU.color = Color.green;
        }
        else
        {
            compatibilityCPU.text = "false";
            compatibilityCPU.color = Color.red;
        }
    }
    public void RAMCOOP()
    {
        if (CurrentRAMslot == CurrentRAMtype)
        {
            RAMCoop = true;
            compatibilityRAM.text = "true";
            compatibilityRAM.color = Color.green;
        }
        else
        {
            compatibilityRAM.text = "false";
            compatibilityRAM.color = Color.red;
        }
    }
    public void CaseCOOP()
    {
        if(CurrentCasetype == CurrentCaseSlot)
        {
            CaseCoop = true;
            compatibilityCase.text = "true";
            compatibilityCase.color = Color.green;
        }
        else
        {
            compatibilityCase.text = "false";
            compatibilityCase.color = Color.red;
        }
    }
    public void COOPORATION()
    {
        
        MotherVersion.text = CurrentMother;
        GPUCOOP();
        CPUCOOP();
        RAMCOOP();
        CaseCOOP();
        compatibilityCooler.text = "true";
        compatibilityCooler.color = Color.green;
        CoopPanel.SetActive(true);
    }
}
