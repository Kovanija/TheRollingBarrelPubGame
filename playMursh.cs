using UnityEngine;
using System.Collections;

public class playMursh : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void murshPlaying()
    {
        buttonEffect.audio.Play();
        Application.LoadLevel("murshState");
    }
}
