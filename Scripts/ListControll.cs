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
        dropdownMother.onValueChanged.AddListener(MotherControl);
        dropdownCPU.onValueChanged.AddListener(CPUControl);
        dropdownGPU.onValueChanged.AddListener(GPUControl);
        dropdownRAM.onValueChanged.AddListener(RAMControl);
        dropdownCase.onValueChanged.AddListener(CaseControl);
        dropdownCoolSystem.onValueChanged.AddListener(CoolControl);
    }
    public void MotherControl(int Value)
    {
        
        if (Value == 1)
        {
            MotherCheck("ASUS ROG Strix Z490-E");
        }
        if (Value == 2)
        {
            MotherCheck("MSI MPG B550 Gaming Edge");
        }
    }
    public void CPUControl(int Value) 
    {
        if (Value == 1)
        {
            CPUCheck("Intel Core i9-11900K");
        }
        if (Value == 2)
        {
            CPUCheck("AMD Ryzen 9 5900X");
        }
    }

    public void GPUControl(int Value) 
    {
        if (Value == 1)
        {
            GPUCheck("NVIDIA GeForce RTX 3080");
        }
        if (Value == 2)
        {
            GPUCheck("AMD Radeon RX 6800 XT");
        }
        if (Value == 3)
        {
            GPUCheck("NVIDIA GeForce GTX 1660");
        }
        if (Value == 4)
        {
            GPUCheck("AMD Radeon RX 5700");
        }
        if (Value == 5)
        {
            GPUCheck("NVIDIA GeForce RTX 3070");
        }
    }
    public void RAMControl(int Value) 
    {
        if (Value == 1)
        {
            RAMCheck("Corsair Vengeance LPX");
        }
        if (Value == 2)
        {
            RAMCheck("G.Skill Trident Z RGB");
        }
    }
    public void CaseControl(int Value) 
    {
        if (Value == 1)
        {
            CaseCheck("NZXT H510");
        }
        if (Value == 2)
        {
            CaseCheck("Corsair 4000D");
        }
    }
    public void CoolControl(int Value) 
    {
        if (Value == 1)
        {
            RAMCheck("Noctua NH-D15");
        }
        if (Value == 2)
        {
            RAMCheck("Corsair H100i RGB Platinum");
        }
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
