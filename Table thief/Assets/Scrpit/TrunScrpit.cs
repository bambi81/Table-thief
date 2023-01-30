using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrunScrpit : MonoBehaviour
{
   public void play(){
        SceneManager.LoadScene(1);
  }
    public void skip()
    {
        SceneManager.LoadScene(2);
    }
    public void next()
    {
        SceneManager.LoadScene(3);
    }
    public void next1()
    {
        SceneManager.LoadScene(4);
    }
    public void next2()
    {
        SceneManager.LoadScene(5);
    }
    public void next3()
    {
        SceneManager.LoadScene(6);
    }
    public void next4()
    {
        SceneManager.LoadScene(7);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}
