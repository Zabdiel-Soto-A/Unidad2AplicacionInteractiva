using UnityEngine;
using UnityEngine.SceneManagement; 

public class ToScene2 : MonoBehaviour
{
    public void LoadingScene2(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
