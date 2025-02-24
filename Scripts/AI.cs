using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class AI_PC_Builder : MonoBehaviour
{
    private string apiKey = "YOUR_OPENAI_API_KEY"; // Replace with your actual OpenAI API key
    private string apiUrl = "https://api.openai.com/v1/chat/completions";

    void Start()
    {
        // Automatically test when game starts
        GetPCBuild(10000, "web programming");
    }

    public void GetPCBuild(int budget, string purpose)
    {
        string prompt = $"The user has {budget} dollars and needs a PC for {purpose}. Suggest 1-3 PC builds with detailed parts and their prices.";
        Debug.Log("Sending prompt to AI: " + prompt);
        StartCoroutine(SendRequest(prompt));
    }

    private IEnumerator SendRequest(string prompt)
    {
        var requestBody = new
        {
            model = "gpt-4",
            messages = new[] { new { role = "user", content = prompt } },
            max_tokens = 500
        };

        string jsonData = JsonConvert.SerializeObject(requestBody);
        using (UnityWebRequest request = new UnityWebRequest(apiUrl, "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Authorization", "Bearer " + apiKey);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Response received: " + request.downloadHandler.text);
                ParseResponse(request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Error: " + request.error);
            }
        }
    }

    private void ParseResponse(string jsonResponse)
    {
        try
        {
            dynamic response = JsonConvert.DeserializeObject(jsonResponse);
            string aiResponse = response.choices[0].message.content;
            Debug.Log("AI Suggestion: " + aiResponse);
        }
        catch (Exception e)
        {
            Debug.LogError("Failed to parse AI response: " + e.Message);
        }
    }
}
