using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureNumScript : MonoBehaviour {

    public TreasureCountScript tcSctipt;
    public GameObject unityChan;
    private int treasure;
    private Text treasureNum;

    // Use this for initialization
    void Start() {
        treasureNum = GetComponentInChildren<Text>();
        unityChan = GameObject.Find("UnityChan");
        tcSctipt = unityChan.GetComponent<TreasureCountScript>();
        treasure = tcSctipt.treasure;
    }
	
	// Update is called once per frame
	void Update () {
        treasureNum.text = treasure.ToString();
    }
}
