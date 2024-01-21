using UnityEngine;
using TMPro;

public class Scr_PointsView : MonoBehaviour
{
    public Scr_Score points;
    public TextMeshProUGUI healthText;




    // Update is called once per frame
    void Update()
    {
        healthText.text = "Points: " + points.Points;
    }
}
