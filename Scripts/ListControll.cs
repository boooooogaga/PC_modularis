using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ListControll : MonoBehaviour
{
    public TMP_Dropdown dropdownMother;
    public TMP_Dropdown dropdownCPU;
    public TMP_Dropdown dropdownGPU;
    public TMP_Dropdown dropdownCase;
    public TMP_Dropdown dropdownRAM;
    public TMP_Dropdown dropdownCoolSystem;
    
    public void Start()
    {
        dropdownMother.onValueChanged.AddListener(index => MotherCheck(dropdownMother.options[index].text));
        dropdownCPU.onValueChanged.AddListener(index => CPUCheck(dropdownCPU.options[index].text));
        dropdownGPU.onValueChanged.AddListener(index => GPUCheck(dropdownGPU.options[index].text));
        dropdownRAM.onValueChanged.AddListener(index => RAMCheck(dropdownRAM.options[index].text));
        dropdownCase.onValueChanged.AddListener(index => CaseCheck(dropdownCase.options[index].text));
        dropdownCoolSystem.onValueChanged.AddListener(index => CoolCheck(dropdownCoolSystem.options[index].text));
    }
    public void MotherCheck(string Motherboard)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.Motherboard.Length; i++)
        {
            if (Prikol.prikol.data2Use.Motherboard[i].model == Motherboard)
            {
                Prikol.prikol.CurrentMother = Prikol.prikol.data2Use.Motherboard[i].model;
                Prikol.prikol.CurrentSocket = Prikol.prikol.data2Use.Motherboard[i].gpuSocket;
                Prikol.prikol.CurrentChipset = Prikol.prikol.data2Use.Motherboard[i].chipset;
                Prikol.prikol.CurrentRAMslot = Prikol.prikol.data2Use.Motherboard[i].ramType;
                Prikol.prikol.CurrentCaseSlot = Prikol.prikol.data2Use.Motherboard[i].formFactor;
                break;
            }
        }        
    }
    public void GPUCheck(string GPU)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.GPU.Length; i++)
        {
            if (Prikol.prikol.data2Use.GPU[i].model == GPU)
            {
                Prikol.prikol.CurrentGPUsocket = Prikol.prikol.data2Use.GPU[i].socket;
                break;
            }
        }

    }
    public void CPUCheck(string CPU)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.CPU.Length; i++)
        {
            if (Prikol.prikol.data2Use.CPU[i].model == CPU)
            {
                Prikol.prikol.CurrentCPUsocket = Prikol.prikol.data2Use.CPU[i].socket;
                break;
            }
        }
    }
    public void RAMCheck(string RAM)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.RAM.Length; i++)
        {
            if (Prikol.prikol.data2Use.RAM[i].model == RAM)
            {
                Prikol.prikol.CurrentRAMtype = Prikol.prikol.data2Use.RAM[i].type;
                break;
            }
        }
    }
    public void CaseCheck(string Case)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.Case.Length; i++)
        {
            if (Prikol.prikol.data2Use.Case[i].model == Case)
            {
                Prikol.prikol.CurrentCasetype = Prikol.prikol.data2Use.Case[i].formFactor;
                break;
            }
        }
    }
    public void CoolCheck(string Cooler)
    {
        for (int i = 0; i < Prikol.prikol.data2Use.CoolingSystem.Length; i++)
        {
            if (Prikol.prikol.data2Use.CoolingSystem[i].model == Cooler)
            {
                Prikol.prikol.CurrentCoolertype = Prikol.prikol.data2Use.CoolingSystem[i].type;
                break;
            }
        }
    }
}
