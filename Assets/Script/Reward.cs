using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Reward : MonoBehaviour
{
     public TextMeshPro scoretext;
     public int score=0;

     public AudioSource Sound;

     public TextMeshPro highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Fruit")){
            score = score+1;
             scoretext.text = score.ToString("0");
           //  string collidedObjectName = other.gameObject.name;
             Sound.Play();
           if(score > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore",score);
            highscore.text = score.ToString();
           }


          Destroy(other.gameObject);
        }
     }

         public void Reset(){
          PlayerPrefs.DeleteAll();
          highscore.text = "0";
         }
    
}
