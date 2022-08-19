using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MALLTOGATE : MonoBehaviour
{
     public void gate()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-4);

   }
    public void exitelec()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

   }
    public void exitfur()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);

   }
   public void avatar()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

   }
    public void gtm()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+4);
    

   }
}
