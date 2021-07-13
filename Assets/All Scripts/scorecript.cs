using UnityEngine.UI;
using UnityEngine;

public class scorecript : MonoBehaviour
{
    public Text score,highscore;
    public PlayerController scorepoint;

    void Update()
    {
        score.text = scorepoint.score.ToString()+ " POINTS";
        highscore.text = "HIGHSCORE : " + scorepoint.highscore.ToString();
    }
    
}
