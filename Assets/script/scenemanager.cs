using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenemanager : MonoBehaviour
{
   public void Electronics()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

   }
    public void clothing()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);

   }
    public void furniture()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);

   }
    public void mall()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);

   }
   public void clothingtogate()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);

   }
}
