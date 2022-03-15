using UnityEngine;
using UnityEngine.SceneManagement;
using RamailoGames;

public class LvlManager : MonoBehaviour
{

    private void Awake()
    {
        ScoreAPI.GameStart();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
