using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
private SpriteRenderer myRender;
    private PlayerMovement pm;
	private Collider2D myCollider;
    public float speedtimer, speedtimelimit, timeLeft = 10f;

    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
		myRender = GetComponent<SpriteRenderer>();
		myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log (myCollider.enabled);
        if(!myCollider.enabled)
		{
		timeLeft-= Time.deltaTime;
		if(timeLeft<0){myRender.enabled=true;	
		myCollider.enabled=true;
		timeLeft = 10f;}
		
		}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pm.increaseSpeed(2);
		myCollider.enabled = false;
		myRender.enabled = false;
        
    }
}

