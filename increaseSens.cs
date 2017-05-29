using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class increaseSens : MonoBehaviour {

    Image sensImage;

    //Sprites for sens
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

	// Use this for initialization
	void Start () {

        sensImage = GameObject.Find("showSensitivity").GetComponent<Image>();

        if (sensitivity.sens == 1)
        {
            sensImage.sprite = sprite1;
        }
        else if (sensitivity.sens == 2)
        {
            sensImage.sprite = sprite2;
        }
        else if (sensitivity.sens == 3)
        {
            sensImage.sprite = sprite3;
        }
        else if (sensitivity.sens == 4)
        {
            sensImage.sprite = sprite4;
        }
        else if (sensitivity.sens == 5)
        {
            sensImage.sprite = sprite5;
        }

    }
	
	// Update is called once per frame
	public void increasedSens()
    {
        buttonEffect.audio.Play();
        if (sensitivity.sens <= 4)
             sensitivity.sens++;

        if (sensitivity.sens == 1)
        {
            sensImage.sprite = sprite1;
        } else if (sensitivity.sens == 2)
        {
            sensImage.sprite = sprite2;
        } else if(sensitivity.sens == 3)
        {
            sensImage.sprite = sprite3;
        } else if(sensitivity.sens == 4)
        {
            sensImage.sprite = sprite4;
        } else if(sensitivity.sens == 5)
        {
            sensImage.sprite = sprite5;
        }

        

    }
}
