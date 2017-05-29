using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class optionsTilting : MonoBehaviour
{

    public static Image theImage;
    public  Sprite sprite1Tilt;
    public  Sprite sprite2Tilt;

    // Use this for initialization
    void Start()
    {
        theImage = GameObject.Find("Tilt").GetComponent<Image>(); 
       

        checkIfTilting();



    }

    void Update()
    {
        checkIfTilting();
    }

    // Update is called once per frame
    void checkIfTilting()
    {
        if (useTilt.useTilting == true)
        {
            theImage.sprite = sprite2Tilt;
        }
        else
        {
            theImage.sprite = sprite1Tilt;
        }
    }

    
    public void Tilt()
    {
        buttonEffect.audio.Play();
        useTilt.useTilting = true;
        useTap.useTapping = false;
        theImage.sprite = sprite2Tilt;
        
    }
    
}
