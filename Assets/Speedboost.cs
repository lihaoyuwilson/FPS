using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedboost : MonoBehaviour {
    public PlayerMovement pm;
    public int i = 0;
    public Text txt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (i > 0)
        {
            txt.text ="Boost time:"+ i/50;
            pm.speed = 20;
            i =i- 1;
        }
        else
        {
            txt.text = "";
            pm.speed = 6;
        }
	}
    public void OnTriggerEnter(Collider other)
    {
        i = 500;
      
    }
}
