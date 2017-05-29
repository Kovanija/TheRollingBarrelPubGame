using UnityEngine;
using System.Collections;

public class touchMursh : MonoBehaviour
{
  
    public static bool playMurshAgain = false;
    AudioSource audio;

    void Start()
    {
        playMurshAgain = false;

        audio = GameObject.Find("Muzika").GetComponent<AudioSource>();
    }

   public void murshTouched()
    {
        buttonEffect.audio.Play();
        Application.LoadLevel("murshStateMainMenu");
        playMurshAgain = true;

        if(musicMutePlay.check % 2 == 0)
        audio.mute = false;
        
    } 

   

    
}

