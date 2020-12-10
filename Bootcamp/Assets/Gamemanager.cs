using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{

    public void Restart()
    {
       Invoke("Res", 1.0f);
    }
    void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
    // Start is called before the first frame update

}
