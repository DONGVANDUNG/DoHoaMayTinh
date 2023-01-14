using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void Pause()
    {
        UnityEditor.EditorApplication.isPaused = true;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
