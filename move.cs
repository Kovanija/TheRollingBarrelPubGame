using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public GameObject coffee;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite spriteIdle;
    SpriteRenderer spriteRendr;
    
   

	// Use this for initialization
	void Start () {

        Screen.orientation = ScreenOrientation.Portrait;
        spriteRendr = GetComponent<SpriteRenderer>();


    }
	
	// Update is called once per frame
	void Update () {


        if(useTap.useTapping == true)
        {
            if (Input.GetMouseButton(0))
            {

                Vector2 touchPosition = Input.GetTouch(0).position;
                double halfScreen = Screen.width / 2.0;



                //Check if it is left or right?
                if (touchPosition.x < halfScreen)
                {
                    spriteRendr.sprite = sprite1;

                        coffee.transform.Translate(Vector3.left * (5 + sensitivity.sens) * Time.deltaTime);
              
                }
                else if (touchPosition.x > halfScreen)
                {
                    spriteRendr.sprite = sprite2;
                    
                        coffee.transform.Translate(Vector3.right * (5 + sensitivity.sens) * Time.deltaTime);
           
                } 
               



            } else
            {
                spriteRendr.sprite = spriteIdle;
            }
           
        } 
        else if(useTap.useTapping == false)
        {
            Vector3 pos = Camera.main.WorldToViewportPoint(coffee.transform.position);
            Vector3 dir = Vector3.zero;
            dir.x = Input.acceleration.x;

            if (dir.sqrMagnitude > 1)
            {
                dir.Normalize();
            }
            dir *= Time.deltaTime;

            if(dir.x > 0)
            {
                spriteRendr.sprite = sprite2;
            } else if(dir.x < 0)
            {
                spriteRendr.sprite = sprite1;
            } else if(dir.x == 0)
            {
                spriteRendr.sprite = spriteIdle;
            }

            if (sensitivity.sens == 1)
                coffee.transform.Translate(dir * 20.0f);
            else if (sensitivity.sens == 2)
                coffee.transform.Translate(dir * 25.0f);
            else if (sensitivity.sens == 3)
                coffee.transform.Translate(dir * 30.0f);
            else if (sensitivity.sens == 4)
                coffee.transform.Translate(dir * 35.0f);
            else if (sensitivity.sens == 5)
                coffee.transform.Translate(dir * 40.0f);

           


        }
        
     
        
        
           


           




        //ogranicenje kasnije eventualno
        /*
            if(pos.x < 0.0)
        {
            coffee.transform.position = new Vector3(Screen.width/Screen.width, -4.13f, 3);
        }
            
            if(1.0 < pos.x)
        {
            coffee.transform.position = new Vector3(Screen.width, -4.13f, 3);
        }
        */
       

      


    
          



    }
}
