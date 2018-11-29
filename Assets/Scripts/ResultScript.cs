using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {

    public TreasureCountScript tcSctipt;
    public CountDownTimer CDTscript;
    public GameObject unityChan;
    public Text timer;

    private bool timeOver;
    private int treasure;
    private Text result;

    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);

        result = GetComponentInChildren<Text>();
        unityChan = GameObject.Find("UnityChan");
        tcSctipt = unityChan.GetComponent<TreasureCountScript>();

        CDTscript = timer.GetComponent<CountDownTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        treasure = tcSctipt.treasure;
        result.text = treasure.ToString();

        timeOver = CDTscript.timeOver;

        if(timeOver == true)
        {
            gameObject.SetActive(true);
        }
    }
}
