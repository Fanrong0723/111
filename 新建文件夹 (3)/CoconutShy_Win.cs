using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoconutShy_Win : MonoBehaviour
{
    public static int targets = 0;
    public AudioClip winsound;
   public static bool havewon = false;
    public GameObject cellprefab;
    float score = 0.0f;
    public Text scoreText_bl;
    float targetdowntimer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(targets == 3){
            targetdowntimer += Time.deltaTime;
            
            if (targetdowntimer >0.4f) {
                Targetcollision.resettime -= 0.2f;
                score += 100;
                targets = 0;
                targetdowntimer = 0.0f;
                scoreText_bl.text = "您的得分为;" + score;
            }
            
           
           

        }
        if (score>=300&&havewon ==false) {
           
            GetComponent<AudioSource>().PlayOneShot(winsound);
            GameObject wincell = transform.Find("powerCell_1").gameObject ;
            wincell.transform.Translate(-1, 0, 0);
            
            GameObject  newcell= Instantiate(cellprefab, wincell.transform.position, Quaternion.identity);
            newcell.transform.localScale = new Vector3(2.0f, 1.2f, 1.2f);
            Destroy(wincell);

            havewon = true;
            scoreText_bl.text = "";
        }
	}
}
