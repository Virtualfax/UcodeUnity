using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    public getscore other;
    private PlayerData pd;
    private PlayerMovement pm;
	private openDoor od;
	private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        pd = FindObjectOfType<PlayerData>();
        pm = FindObjectOfType<PlayerMovement>();
		od = FindObjectOfType <openDoor>();
		gm = FindObjectOfType <GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
	Debug.Log(collision);
        if (this.gameObject.tag == "Coin")
        {
            pd.addPoints(1);
            Destroy(this.gameObject);
			other.setscore(1);
        }
       
        else if (this.gameObject.tag == "Spike")
        {
            pd.loseLives(1);
            pd.makeInvincible();
        }
        else if (this.gameObject.tag == "resetLine")
        {
			gm.lives= 0;
        }
        else if (this.gameObject.tag == "Key")
        {
            pd.pickKey();
            Destroy(this.gameObject);
        }
        else if (this.gameObject.tag == "Door" && pd.gethasKey())
        {
            od.openDoor1();
        }     
		else if (this.gameObject.tag == "Enemy")
        {
            pd.loseLives(1);
            pd.makeInvincible();
        }
    }
}
