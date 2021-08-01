using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getscore : MonoBehaviour

{
    public GameObject scoretext;
    public static float score = 0;

    private void Start()
    {
        setscore(0);
		
    }

    public void setscore(float scoretoadd)
    {
        score += scoretoadd;
		Debug.Log(score);
        scoretext.GetComponent<Text>().text = score.ToString("F0");
    }
}
