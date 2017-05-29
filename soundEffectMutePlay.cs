using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class soundEffectMutePlay : MonoBehaviour {

    public Sprite newSprite;
    public Sprite oldSprite;
    Image theImage;

    private static int check = 0;

    // Use this for initialization
    void Start () {

        theImage = GameObject.Find("soundEffect").GetComponent<Image>();

        if (check % 2 == 0)
        {
            theImage.sprite = oldSprite;
        }
        else
        {
            theImage.sprite = newSprite;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Effect()
    {
        buttonEffect.audio.Play();
        if (check % 2 == 0)
        {
            buttonEffect.audio.mute = true;
            collectBonusEffect.audio.mute = true;
            collectEffect.audio.mute = true;
            lifeSoundEffect.audio.mute = true;
            theImage.sprite = newSprite;

        }
        else if (check % 2 == 1)
        {
            buttonEffect.audio.mute = false;
            collectBonusEffect.audio.mute = false;
            collectEffect.audio.mute = false;
            lifeSoundEffect.audio.mute = false;
            theImage.sprite = oldSprite;

        }

        check++;


    }
}
