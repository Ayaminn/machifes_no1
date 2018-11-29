using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCountScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Treasure")
        {
            Destroy(col.gameObject);
            Debug.Log("おたからみーっけ！");
        }

    }
}
