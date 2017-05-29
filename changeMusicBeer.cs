using UnityEngine;
using System.Collections;

public class changeMusicBeer : MonoBehaviour {

    AudioSource muzikaBeer;
    public AudioClip muzikaBeerClip;

    // Use this for initialization
    void Start()
    {

        muzikaBeer = GameObject.Find("Muzika").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playBeerMuzika()
    {
        muzikaBeer.clip = muzikaBeerClip;
        muzikaBeer.Play();
    }
}
