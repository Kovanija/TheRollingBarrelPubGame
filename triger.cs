using UnityEngine;
using System.Collections;

public class triger : MonoBehaviour {

    public GameObject murshmallow;
    
    
    
    private bool trigering = false;
    private bool killTrigering = false;
    public static bool isDead = false;
    public static int countScore = 0;
    public static bool callScore = false;
    private static int health;
    AudioSource audio;
    AudioSource audioLife;

   
   
    


	// Use this for initialization
	void Start () {
        audio = GameObject.Find("Collect").GetComponent<AudioSource>();
        audioLife = GameObject.Find("LifeSound").GetComponent<AudioSource>();
        countScore = 0;
        health = 0;
        
      
    }
	
	// Update is called once per frame
	void Update () {

        if(trigering)
        {
            trigering = false;  
        }

        if (killTrigering)
        {
            audioLife.Play();
            health++;
           
            killTrigering = false;

            if (health == 3)
            {
                Application.LoadLevel("playScreenAgain");
                isDead = true;
            }

            if (health == 1)
            {
                Destroy(GameObject.Find("Life3"));
            }
            else if (health == 2)
            {
                Destroy(GameObject.Find("Life2"));
            }
            else if (health == 3)
            {
                Destroy(GameObject.Find("Life1"));
            }

           

        }


    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coffee")
        {
            audio.Play();
            trigering = true;
            score.countScore = score.countScore + 25;
            callScore = true;
            
        }

        if (other.tag == "kill")
        {
            killTrigering = true;
        }

        murshmallow.transform.position = new Vector3(Random.Range(-1.5f, +1.5f), Random.Range(6, 18), 3);
 
    }

    
}
