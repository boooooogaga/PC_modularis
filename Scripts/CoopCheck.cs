using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
[System.Serializable]
public class CoopData
{
    public Dictionary<string, Dictionary<string, Dictionary<string, string>>> data;
}
public class CoopCheck : MonoBehaviour
{
    public CoopData CoopData;

   
    // Start is called before the first frame update
    void Start()
    {
        string path = "D:\\Unity\\PC_modularis\\Assets\\PC_modularis\\datasets\\test-data.json";


        if (File.Exists(path))
        {
            string jsonText = File.ReadAllText(path);
            CoopCheck datas = JsonUtility.FromJson<CoopCheck>(jsonText);
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> CoopData = datas.CoopData.data;
        }
        else
        {
            Debug.LogError("Файл не найден: " + path);
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
