using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private PlayerData pd;
    void Start()
    {
        pd = FindObjectOfType<PlayerData>();
    }

   
    void Update()
    {
        
    }
	 void OnTriggerEnter(Collider col){ Debug.Log("collission"); if(col.gameObject.name == "Player"){ Debug.Log("Player");  pd.loseLives(1);
  pd.makeInvincible(); }
 }
}
