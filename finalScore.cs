using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class finalScore : MonoBehaviour {

    public int newScore;
    public int oldScore;

   

   

    public Text drawCurrentScore;
    public Text drawHighScore;

   


    // Use this for initialization
    void Start () {

        

        newScore = score.countScore;
        load();
        
        if (newScore > oldScore)
        {
            save();
        }

        drawCurrentScore.text = "Your score : " + newScore.ToString();
        drawHighScore.text = "High score : " + oldScore.ToString();





    }
	
	// Update is called once per frame
	


    //save file 
    public void save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/info.dat");

        PlayerData data = new PlayerData();
        data.highScore = score.countScore;

        bf.Serialize(file,data);
        file.Close();
    }
    //load file
    public void load()
    {
        if (File.Exists(Application.persistentDataPath + "/info.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/info.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            oldScore = data.highScore;

        }else
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/info.dat");

            PlayerData data = new PlayerData();
            data.highScore = 0;

            bf.Serialize(file, data);
            file.Close();
           
        }


    }

   
    [Serializable]
    class PlayerData

    {
        public int highScore;
    }
        
	
	}

  

