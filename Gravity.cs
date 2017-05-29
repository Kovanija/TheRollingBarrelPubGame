using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gravity : MonoBehaviour {

    public GameObject murshObject;
    public GameObject murshObject2;
    public GameObject murshObject3;
    private float speed;

    //pause

    private int pauseGame;
    Image image;
    private float saveLastSpeed;
   

    // Use this for initialization
    void Start () {

        image = GameObject.Find("Pauza").GetComponent<Image>();
        image.fillAmount = 0;
        pauseGame = 2;

        speed = 5.0f;

    }
	
	// Update is called once per frame
	void Update () {

        speed = speed + 0.0005f;
        murshObject.transform.Translate(Vector3.down * (speed+0.4f) * Time.deltaTime);
        murshObject2.transform.Translate(Vector3.down * speed * Time.deltaTime);
        murshObject3.transform.Translate(Vector3.down * (speed-0.4f) * Time.deltaTime);

        

    }

    public void pauziraj()
    {
        if (pauseGame % 2 == 0)
        {
            score.countScore = score.countScore + 137; // bezbednosni propust;
            saveLastSpeed = speed;
            Time.timeScale = 0;
            image.fillAmount = 1;
            Debug.Log(score.countScore);


        }
        else
        {
            score.countScore = score.countScore - 137; // bezbednosni propust;
            speed = saveLastSpeed;
            Time.timeScale = 1;
            image.fillAmount = 0;
            Debug.Log(score.countScore);
        }
        pauseGame++;
    }

}
