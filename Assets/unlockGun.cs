using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockGun : MonoBehaviour {
    public GameObject gun1;
    public GameObject gun2;
    public bool getgun2=false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)&&getgun2==true)
        {
            gun2.SetActive(true);
            gun1.SetActive(false);
        }

    }
}
