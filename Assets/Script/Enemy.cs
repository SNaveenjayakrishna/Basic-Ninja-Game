using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 startPosition;
    public Vector3 targetPosition;
    public float Movespeed;
    private bool movingtowardstargetposition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        movingtowardstargetposition = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(movingtowardstargetposition == true){
            transform.position = Vector3.MoveTowards(transform.position, targetPosition,Movespeed*Time.deltaTime);
            if(transform.position == targetPosition){
                movingtowardstargetposition = false;
            }
        }
        else{
           transform.position = Vector3.MoveTowards(transform.position, startPosition,Movespeed*Time.deltaTime);
            if(transform.position == startPosition){
                movingtowardstargetposition = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<Player>().GameOver();
        }
    }
}
//time.deltatime = it move object at movespeed per second and not per frame .so in all computer we will have same speed for object movement
