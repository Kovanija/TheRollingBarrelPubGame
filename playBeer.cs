using UnityEngine;
using System.Collections;

public class playBeer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void beerPlaying()
    {
        buttonEffect.audio.Play();
        Application.LoadLevel("beerState");
    }

}
