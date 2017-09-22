using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenue : MonoBehaviour {
    public stair ok;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        ok.start = true;
    }
}
