using UnityEngine;
using System.Collections;

public class useTap : MonoBehaviour {
    public static bool useTapping;

	// Use this for initialization
	void Start () {

        useTapping = false;
	
	}

    // Update is called once per frame
    public void useTappin()
    {
        buttonEffect.audio.Play();
        useTapping = true;
        Application.LoadLevel("playScreen");
        

    }
}
