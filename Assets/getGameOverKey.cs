﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGameOverKey : MonoBehaviour {
    public GameOver showpic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        showpic.gg = true; 
    }
}
