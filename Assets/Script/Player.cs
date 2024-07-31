using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   public float minX = 7f;
    public float maxX = 60f;
    public float Movespeed;
    public Rigidbody2D myrig;
    public float jump;
public SpriteRenderer sr;

public GameObject Failed;
public GameObject winmenu;




    private void FixedUpdate(){//called every 0.02 seconds - used mainly for //working with physics
    //meaning that if your frame rate is slower than 50 fps , //then fixedupdate will run more frequently than update
    
    float xInput = Input.GetAxis("Horizontal");
    myrig.velocity = new Vector2(xInput * Movespeed, myrig.velocity.y);

//to restrict the player from moving beyond the position
     float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        myrig.transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

   
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
      winmenu.SetActive(false); 
         Failed.SetActive(false); 
         
    }

    // Update is called once per frame. called every single frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.UpArrow)&&isOntheGround())  {
        myrig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);//force = gradual force increase, impulse = instant velocity
      }

      if(myrig.velocity.x > 0){
        sr.flipX = false;
      }
      else if(myrig.velocity.x < 0){
        sr.flipX = true;
      }

    if (Failed != null)
        {
            if (Failed.activeSelf)
            {
                //Debug.Log("UI element is enabled.");
                Time.timeScale = 0f;
            }
            else
            {
               // Debug.Log("UI element is disabled.");
                Time.timeScale = 1.0f;
            }
        }
      

      

    }

    bool isOntheGround(){
        //whenever we are raycast something and it hits something , it get that object collider
        //,and store it inside of this hit variable
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0,-1.01f,0), Vector2.down, 0.2f);
        //we want to return a condition whether or not this collider doesnot equal null
        //that means if it hit something it return it true otherwise if this collider doesnot exist
        //then return it false
        return hit.collider != null;
    }

    public void GameOver(){
      
      // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("Level01");
        Failed.SetActive(true);
      
    }
   private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Final")){
           Debug.Log("Final Cup");
           winmenu.SetActive(true);
        }
    }
  
}
