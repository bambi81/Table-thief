using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoretext;
    public float score;
    private float fromscore;
    private float toscore;
    public float animationtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollingScore();
        }
    }
    private void RollingScore()
    {
        fromscore = 0;
        toscore = fromscore + score; 
        LeanTween.value(fromscore, toscore, animationtime)
            .setEase(LeanTweenType.easeInOutQuart)
            .setOnUpdate(UpateScoreUI);
        
            
    }

    private void UpateScoreUI(float _obj)
    {
        fromscore = _obj;
        scoretext.text = "±o¤À:" + _obj.ToString("000000");
    }
}
