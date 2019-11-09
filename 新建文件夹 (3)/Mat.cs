using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mat : MonoBehaviour {
    public RawImage crosshair_bl;
    public Text coconutShyText_bl;
    float infoTexttimer=0.0f;
	// Use this for initialization
	void Start () {
        crosshair_bl.enabled =false;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (coconutShyText_bl.enabled) {
            infoTexttimer += Time.deltaTime;
            if (infoTexttimer > 3.0f) {
                coconutShyText_bl.enabled = false;
                infoTexttimer = 0.0f;
            }
        }
		
	}
    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            CoconutThrower.canthrow = true;
            crosshair_bl.enabled = true;
            if (CoconutShy_Win.havewon ==false) {
                coconutShyText_bl.enabled = true;
                coconutShyText_bl.text = "提示信息：鼠标左键射击  击中三个靶位拿电池";
            }
        }
    }
    void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player")
            CoconutThrower.canthrow = false;
    }

}
