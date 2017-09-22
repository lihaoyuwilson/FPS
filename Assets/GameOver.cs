using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public Image si;
    Color c;
    public bool gg=false;
    // Use this for initialization
    void Start () {
        c = si.color;
        c.a = 0;
        si.color = c;
    }
	
	// Update is called once per frame
	void Update () {
        if (gg == true)
        {
            c = si.color;
            c.a = 1;
            si.color = c;
        }
    }
   
}
