using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class backToMainMenu : MonoBehaviour {

  

	public void back()
    {
      
        if(touchBeer.playBeerAgain == true)
        {
            buttonEffect.audio.Play();
            Application.LoadLevel("beerStateMainMenu");
        }
        else if(touchMursh.playMurshAgain == true)
        {
            buttonEffect.audio.Play();
            Application.LoadLevel("murshStateMainMenu");
        }
        
    }
}
