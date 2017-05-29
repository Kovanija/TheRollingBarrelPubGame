using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class musicMutePlay : MonoBehaviour {


    public Sprite newSprite ;
    public Sprite oldSprite ;
    Image theImage;
    
    


    public static int check = 0;

    // Use this for initialization

        void Start()
    {
         theImage = GameObject.Find("Music").GetComponent<Image>();

        if(check % 2 == 0)
        {
            theImage.sprite = oldSprite;
        }
        else
        {
            theImage.sprite = newSprite;
        }
       
    }
   
	
	// Update is called once per frame
	public void musicMute()
    {
        buttonEffect.audio.Play();
        if (check % 2 == 0)
        {
            musicScript.audio.mute = true;
            theImage.sprite = newSprite;
         
        }
        else if (check % 2 == 1)
        {
            musicScript.audio.mute = false;
            theImage.sprite = oldSprite;
          
        }

        check++;

  
    }
}
