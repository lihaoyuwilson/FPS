using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGun : MonoBehaviour {
    public unlockGun get;
    public bool key=false;
        
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (key == true)
        {
            hasKeytoGetGun();
        }
       
        
    }
    void hasKeytoGetGun()
    {
        get.getgun2 = true;
        gameObject.SetActive(false);
    }
}
