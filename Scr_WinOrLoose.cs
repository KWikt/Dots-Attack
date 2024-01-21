using UnityEngine;
using UnityEngine.SceneManagement;


public class Scr_WinOrLoose : MonoBehaviour
{


    public void WinGameScreen()
    {
  
        SceneManager.LoadScene("Win");
    }
    public void LooseGameScreen()
    {
      
        SceneManager.LoadScene("TheEnd");
    }
}
