using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool flag = true;
    public void Restart()
    {
       Invoke("Res", 1.0f);
    }
    void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
    public void NextLevel()
    {
        if(flag)
        {
            Invoke("NextLevel", 1.0f);
            flag = false;
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
