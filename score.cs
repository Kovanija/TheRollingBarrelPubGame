using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

    public static int countScore;

    public Text scoreText;

    // Use this for initialization
    void Start () {
        countScore = 0;
        setScoreText();

       
    }
	
	// Update is called once per frame
	void Update () {

        if (triger.callScore == true)
        {
            setScoreText();
        }
    }

   public void setScoreText()
    {
        scoreText.text = "Score : " + countScore.ToString();
        triger.callScore = false;
    }

  
}
