using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class APIManager : MonoBehaviour
{
    private const string apiUrl = "https://api.example.com/data"; // Replace with your API URL

    void Start()
    {
        StartCoroutine(FetchData());
    }

    IEnumerator FetchData()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            request.downloadHandler = new DownloadHandlerBuffer();
            
            yield return request.SendWebRequest();
            
            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                Debug.Log("Received JSON: " + json);
                
                // Optionally, deserialize JSON into a C# object
                MyData data = JsonUtility.FromJson<MyData>(json);
                Debug.Log("Parsed data: " + data.someField);
            }
            else
            {
                Debug.LogError("Error fetching data: " + request.error);
            }
        }
    }
}

[System.Serializable]
public class MyData
{
    public string someField; // Adjust to match your JSON structure
}
