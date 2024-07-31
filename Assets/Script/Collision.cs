using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    
   // public GameObject Failed;
    // Start is called before the first frame update
    void Start()
    {
     //Failed.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
           other.gameObject.GetComponent<Player>().GameOver();
           //Failed.SetActive(true);
        }
    }
}
