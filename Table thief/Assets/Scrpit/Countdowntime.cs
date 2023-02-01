using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdowntime : MonoBehaviour
{
    public int seconds;
    public int sec;
    public int min;
    public float maxtime;
    //public float now;
    public Image Bar;
    public Text timer;
    public Text gameover;
    public GameObject img;
    public GameObject explainpanle;
    public GameObject dialoguepanle;
    void Start()
    {
        Time.timeScale = 1;
       
    }
     void Update()
    {
        Bar.fillAmount = seconds / maxtime;
    }
    public void endconversation()
    {
        dialoguepanle.SetActive(false);
        explainpanle.SetActive(true);
    }
    public void start()
    {
        explainpanle.SetActive(false);
        
        StartCoroutine(Counttime());
    }
    IEnumerator Counttime()
    {
        timer.text = string.Format("{0}:{1}", min.ToString("00"),sec.ToString("00"));
        seconds = (min * 60) + sec;
        while (seconds > 0)
        {
            yield return new WaitForSeconds(1);
            seconds--;
            sec--;
            if(sec<0 && min > 0)
            {
                min -= 1;
                sec = 59;
            }
            else if(seconds<10)
            {
                img.SetActive(true);
                yield return new WaitForSeconds(0.2f);
                img.SetActive(false);
                 if (sec < 0 && min == 0)
                {
                    sec = 0;
                }
            }
          
            timer.text = string.Format("{0}:{1}", min.ToString("00"), sec.ToString("00"));
        }
        yield return new WaitForSeconds(1);
        gameover.text = "Game over!";
        Time.timeScale = 0;
    }


}
