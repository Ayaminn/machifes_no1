using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCountScript : MonoBehaviour {

    public int treasure = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Treasure")
        {
            treasure ++;
            Destroy(col.gameObject);
        }

    }
}
