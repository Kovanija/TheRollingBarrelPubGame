using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class optionsTapping : MonoBehaviour {

    public static Image theImage;
    public Sprite sprite1Tap;
    public Sprite sprite2Tap;

    // Use this for initialization
    void Start () {

        theImage = GameObject.Find("Tap").GetComponent<Image>();

        checkIfTapping();

       


    }

    void Update()
    {
        checkIfTapping();
    }

    // Update is called once per frame 
    void checkIfTapping()
    {
        if(useTap.useTapping == true)
        {
            theImage.sprite = sprite2Tap;
        }
        else
        {
            theImage.sprite = sprite1Tap;
        }
    }

    
   public void Tap()
    {
        buttonEffect.audio.Play();
        useTap.useTapping = true;
        useTilt.useTilting = false;
        theImage.sprite = sprite2Tap;
        
    }
    
}
