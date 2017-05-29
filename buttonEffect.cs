using UnityEngine;
using System.Collections;

public class buttonEffect : MonoBehaviour {

    public GameObject muzika;
    public static AudioSource audio;
    // Use this for initialization
    void Start () {

        DontDestroyOnLoad(muzika);
        audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
