using UnityEngine;
using UnityEngine.SceneManagement;
using RamailoGames;

public class LvlManager : MonoBehaviour
{

   
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
