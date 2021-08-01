using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    private PlayerMovement pm;
	private GameManager gm;

   

    public bool invincible, flashing, hasKey;

    public float timeElapInv, timeLimitInv = 2f, timeflashing, timeflashinglimit;

    // Start is called before the first frame update
    void Start()
    {
	
        pm = FindObjectOfType<PlayerMovement>();
		gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashing)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.588f); // Our Ghost
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1); // Our original color
        }

        if (invincible)
        {
            timeflashing += Time.deltaTime;

            if (timeflashing >= timeflashinglimit)
            {
                flashing = !flashing;
                timeflashing = 0f;
            }

            timeElapInv += Time.deltaTime;

            if (timeElapInv >= timeLimitInv)
            {
                invincible = false;
                timeElapInv = 0f;
            }
        }
        else
        {
            flashing = false;
        }

        
    }

    public void addPoints(int points)
    {
        points += points;
    }

    public void loseLives(int live)
    {
        if (!invincible) gm.loseLives(live);
    }



    public void makeInvincible()
    {
        invincible = true;
    }

    public void pickKey()
    {
        hasKey = true;
    }

    public bool gethasKey()
    {
        return hasKey;
    }
}
