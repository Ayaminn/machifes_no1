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
        result = GetComponentInChildren<Text>();
        CDTscript = timer.GetComponent<CountDownTimer>();
        tcSctipt = unityChan.GetComponent<TreasureCountScript>();

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        treasure = tcSctipt.treasure;
        timeOver = CDTscript.timeOver;

        if(timeOver == true)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }

            if(treasure < 1)
            {

                result.text = ("ざんねんでした！");

            } else if(treasure < 3){

                result.text = ("まだまだ だな・・・");

            } else if(treasure < 5)
            {
                result.text = ("まあまあスゴイぞ");
            }
            else
            {
                result.text = ("すごい！かんぺきだ！");
            }
        }
    }
}
