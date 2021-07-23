using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestion_scene : MonoBehaviour
{
   public void goToGame()
   {
       SceneManager.LoadScene("Game");
   }
   public void quit()
   {
       Application.Quit();
   }
   public void retour()
   {
       SceneManager.LoadScene("menu");
   }
   
}
