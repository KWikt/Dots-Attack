using UnityEngine;

public class Scr_Score : MonoBehaviour
{
    public Scr_PlayerConfig playerConfig;

    private int points = 0;

    [SerializeField] int pointsToWin;

  
    public Debugger debugger;
    public Scr_WinOrLoose win;
    [Header("Debugging")]
    [SerializeField] bool pointsDebug;

    private void Update()
    {
        WinGame();
    }


    public int Points { get => points; set => points = value; }
 

    public void addPoints()
    {
        Points += playerConfig.Points;
        debugger.Log(Points, pointsDebug);
    }

    public void subtractPoints()
    {
        Points -= playerConfig.Points;
        debugger.Log(Points, pointsDebug);
    }

    public void WinGame()
    {
        if(points == pointsToWin)
        {
            win.WinGameScreen();
        }
    }

    public void Reset()
    {
        points = 0;
    }

}
