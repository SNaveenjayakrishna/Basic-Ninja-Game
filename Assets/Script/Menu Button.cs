using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    
    public GameObject Setting;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
       Menu.SetActive(true);
       Setting.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void Startbutton(){
         SceneManager.LoadScene("Level01");
    }

       public void Quit(){
       Application.Quit();
       Debug.Log("Quit");
   }

   public void Settings(){
        Setting.SetActive(true);
        Menu.SetActive(false);
   }

   public void Back(){
      Setting.SetActive(false);
      Menu.SetActive(true);
   }
}
