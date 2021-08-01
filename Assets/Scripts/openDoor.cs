using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
	public float z_angle = 0f;
	public bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
        if(transform.rotation.eulerAngles.z <= 90 && doorOpen)
		{
	     z_angle += Time.deltaTime;
	     transform.Rotate(new Vector3(0, 0, z_angle));
		}
	}
	public void openDoor1()
	{
		doorOpen = true;
	}
}
