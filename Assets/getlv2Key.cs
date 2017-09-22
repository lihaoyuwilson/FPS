using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getlv2Key : MonoBehaviour {
    public golevel2 getKey;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {

        getKey.haslv2key = true;
        gameObject.SetActive(false);
    }
}
