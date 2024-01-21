using UnityEngine;
using UnityEngine.SceneManagement;


public class Scr_Menu : MonoBehaviour
{


    public void exitGame()
    {
        Application.Quit();

    }

   public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
