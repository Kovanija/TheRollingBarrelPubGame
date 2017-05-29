using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class diskoteka : MonoBehaviour {

    public Image ButtonBackground;
    public Color color;


    // Use this for initialization
    void Start () {

        ButtonBackground = GameObject.Find("Diskoteka").GetComponent<Image>();
        color = ButtonBackground.color;
        color.a = 0.0f;
        ButtonBackground.color = color;


    }
	
	// Update is called once per frame
	
    void OnGUI()
    {
        Color textureColor = ButtonBackground.color;
        textureColor.a = Mathf.Sin(Time.time * 1.5f);
        ButtonBackground.color = textureColor;
    }

    public void fadeColor()
    {

    }
}
