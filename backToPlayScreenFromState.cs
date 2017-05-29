using UnityEngine;
using System.Collections;

public class backToPlayScreenFromState : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void btpsfs()
    {
       
            buttonEffect.audio.Play();
            Application.LoadLevel("playScreen");
       
    }
}
