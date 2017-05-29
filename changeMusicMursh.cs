using UnityEngine;
using System.Collections;

public class changeMusicMursh : MonoBehaviour {

    AudioSource muzikaMursh;
    public AudioClip muzikaMurshClip;

	// Use this for initialization
	void Start () {

        muzikaMursh = GameObject.Find("Muzika").GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playMurshMuzika()
    {
        muzikaMursh.clip = muzikaMurshClip;
        muzikaMursh.Play();
    }
}
