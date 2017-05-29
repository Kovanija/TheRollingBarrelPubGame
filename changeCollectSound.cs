using UnityEngine;
using System.Collections;

public class changeCollectSound : MonoBehaviour {

    AudioSource audioCollect;
    public AudioClip collect0;
    public AudioClip collect1000;
    public AudioClip collect2000;
    public AudioClip collect3500;
    public AudioClip collect5000;
    public AudioClip collect7000;
    public AudioClip collect9000;

	// Use this for initialization
	void Start () {
        audioCollect = GameObject.Find("Collect").GetComponent<AudioSource>();
        audioCollect.clip = collect0;
	}
	
	// Update is called once per frame
	void Update () {
            
        if(score.countScore == 0 || score.countScore == 1000 || score.countScore == 2000 || score.countScore == 3500 || score.countScore == 5000 || score.countScore == 7000 || score.countScore == 9000)
        {
            callAudioChanging();
        }
       
	
	}

    public void callAudioChanging()
    {
        if(score.countScore == 0)
        {
            audioCollect.clip = collect0;
        }
        else if (score.countScore == 1000)
        {
            audioCollect.clip = collect1000;
        }
        else if (score.countScore == 2000)
        {
            audioCollect.clip = collect2000;
        }
        else if (score.countScore == 3500)
        {
            audioCollect.clip = collect3500;
        }
        else if (score.countScore == 5000)
        {
            audioCollect.clip = collect5000;
        }
        else if (score.countScore == 7000)
        {
            audioCollect.clip = collect7000;
        }
        else if (score.countScore == 9000)
        {
            audioCollect.clip = collect9000;
        }
      
    }
}
