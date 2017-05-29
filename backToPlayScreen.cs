using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class backToPlayScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void  backToPlayscr()
    {
        buttonEffect.audio.Play();

        if(touchBeer.playBeerAgain == true)
        {
            Application.LoadLevel("beerStateMainMenu");
        } else if(touchMursh.playMurshAgain == true)
        {
            Application.LoadLevel("murshStateMainMenu");
        }
        
    }
}
