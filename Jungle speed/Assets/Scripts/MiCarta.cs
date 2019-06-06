using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiCarta : MonoBehaviour {

    public GameObject prefav = null;
	// Use this for initialization
	void Start () {
        Instantiate(prefav,
            transform.position,
            Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
