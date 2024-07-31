using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject PauseMenu;
   
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReStart(){
         SceneManager.LoadScene("Level01");
         Time.timeScale = 1f;
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
        PauseMenu.SetActive(false);
       Time.timeScale = 1f;
    }
       public void Quit(){
       Application.Quit();
       Debug.Log("Quit");
   }

   public void pause(){
       PauseMenu.SetActive(true);
       Time.timeScale = 0f;
   }
   public void Resume(){
       PauseMenu.SetActive(false);
       Time.timeScale = 1f;
   }




}
