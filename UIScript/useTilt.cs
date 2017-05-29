using UnityEngine;
using System.Collections;

public class useTilt : MonoBehaviour {

    public static bool useTilting ;

	// Use this for initialization
	void Start () {
        useTilting = false;
	}

    // Update is called once per frame
    public void useTiltin()
    {
        buttonEffect.audio.Play();
        useTilting = true;
        Application.LoadLevel("playScreen");
       

    }
}
