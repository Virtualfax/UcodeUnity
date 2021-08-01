using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
	private GameManager gm;
    float horizontalMove = 0f;

    public float speed = 2f;

    public float timeElapsed, timeLimit;

    public bool jump = false, speedBoosted = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController2D>();
		gm = FindObjectOfType<GameManager>();
        timeLimit = 5f;
    }

    // Update is called once per frame
    void Update()
    {
	 
        if (speedBoosted)
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed >= timeLimit)
            {
                speed = 2f;
                speedBoosted = false;
                timeElapsed = 0f;
            }
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
		
		GetComponent<Rigidbody2D>().simulated = !gm.endMenue.activeSelf;

    }

    private void FixedUpdate()
    {
       controller.Move(horizontalMove, false, jump);
    }

    public void stayGrounded()
    {
        jump = false;
    }

    public void increaseSpeed(float num)
    {
        speed *= num;
        speedBoosted = true;
    }

    public void relocate(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }
}
