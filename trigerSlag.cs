using UnityEngine;
using System.Collections;

public class trigerSlag : MonoBehaviour {

    public GameObject slag;
    AudioSource audioSlag;

	// Use this for initialization
	void Start () {
        audioSlag = GameObject.Find("Collect_Bonus").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coffee")
        {
            audioSlag.Play();
            score.countScore = score.countScore + 300;
            triger.callScore = true;
        }

       

        slag.transform.position = new Vector3(Random.Range(-1.5f, +1.5f), Random.Range(160, 260), 3);




    }
}
