﻿using System.Collections;
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
	
  pd.makeInvincible();
 }
}