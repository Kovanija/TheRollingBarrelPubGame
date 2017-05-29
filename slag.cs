using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class slag : MonoBehaviour {

    public GameObject slagObject;
    private float speedSlag;

    //pause
    private int pauseGame;
    Image image;
 
    private float saveLastSlagSpeed;

    // Use this for initialization
    void Start () {

        image = GameObject.Find("Pauza").GetComponent<Image>();
        image.fillAmount = 0;
        pauseGame = 2;

        speedSlag = 8.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

        speedSlag = speedSlag + 0.0005f;
        slagObject.transform.Translate(Vector3.down * speedSlag * Time.deltaTime);
	
	}

    public void pauziraj()
    {
        if (pauseGame % 2 == 0)
        {
            score.countScore = score.countScore  + 137; // bezbednosni propust
            saveLastSlagSpeed = speedSlag;
            Time.timeScale = 0;
            image.fillAmount = 1;
            Debug.Log(score.countScore);
            


        }
        else
        {
            score.countScore = score.countScore  - 137; // bezbednosni propust
            speedSlag = saveLastSlagSpeed;
            Time.timeScale = 1;
            image.fillAmount = 0;
            Debug.Log(score.countScore);
            
           
        }
        pauseGame++;
    }

}
