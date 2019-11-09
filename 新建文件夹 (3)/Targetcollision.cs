using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetcollision : MonoBehaviour {
    public AudioClip hitsound;
    Animation targetAnimation;
    bool beenhit = false;
    public static float resettime = 3.0f;
    // Use this for initialization
    void Start () {
        targetAnimation = transform.parent.transform.parent.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision theobject) {
        if (theobject .gameObject .name=="Coconut"&&beenhit==false ) {
            StartCoroutine(Target());
            GetComponent<AudioSource>().PlayOneShot(hitsound);
            targetAnimation.Play("down");
            beenhit = true;
        }
    }
    IEnumerator Target()
    {
        GetComponent<AudioSource>().PlayOneShot(hitsound);
        targetAnimation.Play("down");
        beenhit = true;
        CoconutShy_Win.targets++;
        yield return new WaitForSeconds(resettime);

        GetComponent<AudioSource>().PlayOneShot(hitsound);
        targetAnimation.Play("up");
        beenhit = false;
      //  CoconutShy_Win.targets--;

    }
}
