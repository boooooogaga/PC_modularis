using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    //����� ����� �� ����
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
