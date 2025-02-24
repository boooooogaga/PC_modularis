using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    //«м≥нюЇ сцену по назв≥
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
