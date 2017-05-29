using UnityEngine;
using System.Collections;

public class touchBeer : MonoBehaviour
{
 
    public static bool playBeerAgain = false;
    AudioSource audio;

    void Start()
    {
        playBeerAgain = false;

        audio = GameObject.Find("Muzika").GetComponent<AudioSource>();

    }

   public void beerTouched()
    {
        buttonEffect.audio.Play();
        Application.LoadLevel("beerStateMainMenu");
        playBeerAgain = true;

        if (musicMutePlay.check % 2 == 0)
            audio.mute = false;


    } 

   
  
   

    
}

