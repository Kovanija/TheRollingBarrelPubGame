using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class openOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void optionsOpenned()
    {
        buttonEffect.audio.Play();
        Application.LoadLevel("options");
        
    }
}
