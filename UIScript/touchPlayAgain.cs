using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class touchPlayAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
   public void playAgainPressed()
    {
        if(touchMursh.playMurshAgain == true)
        {
            Application.LoadLevel("murshState");
        } else if(touchBeer.playBeerAgain == true)
        {
            Application.LoadLevel("beerState");
        }
        
    }
}
