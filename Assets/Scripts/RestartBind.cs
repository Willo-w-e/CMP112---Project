using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBind : MonoBehaviour
{
    void Update()
    {
        // Restart scene when the player presses R
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
