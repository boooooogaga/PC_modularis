using UnityEngine;
using System.IO;

public class HardwareDataLoader : MonoBehaviour
{
    [System.Serializable]
    public class GPUData
    {
        public string model;
        public string memory;
        public string coreClock;
        public string socket;
        public float price;
    }

    [System.Serializable]
    public class CPUData
    {
        public string model;
        public int cores;
        public string baseClock;
        public string socket;
    }

    [System.Serializable]
    public class RAMData
    {
        public string model;
        public string capacity;
        public string speed;
        public string type;
    }

    [System.Serializable]
    public class MotherboardData
    {
        public string model;
        public string chipset;
        public string formFactor;
        public string gpuSocket;
        public string ramType;
    }

    [System.Serializable]
    public class SSDData
    {
        public string model;
        public string capacity;
        public string interfaceType;
    }

    [System.Serializable]
    public class CaseData
    {
        public string model;
        public string formFactor;
        public string color;
    }

    [System.Serializable]
    public class CoolingData
    {
        public string model;
        public string type;
        public string fanSize;
    }

    [System.Serializable]
    public class HardwareData
    {
        public GPUData[] GPU;
        public CPUData[] CPU;
        public RAMData[] RAM;
        public MotherboardData[] Motherboard;
        public SSDData[] SSD;
        public CaseData[] Case;
        public CoolingData[] CoolingSystem;
    }

    private GameObject flexObject;
    [SerializeField] bool debugger = false;

    public HardwareData hardware;


    public HardwareData GetHardwareData()
    {
        return hardware;
    }


    void Start()
    {
        flexObject = GameObject.FindWithTag("flex");
        if (flexObject == null)
        {
            if(debugger) Debug.LogError("������ � ����� 'flex' �� ������ �� �����!");
            return;
        }

        string filePath = Path.Combine(Application.dataPath, "PC_modularis/datasets/test-data.json");

        if (debugger) Debug.Log($"�������� ��������� ���� �� ����: {filePath}");

        try
        {
            if (File.Exists(filePath))
            {
                if (debugger) Debug.Log("������...");
                string jsonData = File.ReadAllText(filePath);
                if (debugger) Debug.Log("���������� �������: " + jsonData.Substring(0, Mathf.Min(100, jsonData.Length)) + "..."); // ���������� ������ 100 �������� ��� �������
                hardware = JsonUtility.FromJson<HardwareData>(jsonData);

                if (hardware == null)
                {
                    Debug.LogError("�������������� �� �������((((");
                    return;
                }              
            }
            else
            {
                if (debugger) Debug.LogError($"���� �� ������ �� ����: {filePath}");
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"������ ��� �������� ��� �������������� JSON: {e.Message}");
        }
    }

    

}


