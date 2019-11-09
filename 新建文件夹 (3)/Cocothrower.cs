using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coconutthrower : MonoBehaviour
{
    public AudioClip throwsound;
    public Rigidbody coconut_bl;
    public static bool canthrow = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Frie1")&&canthrow)
            GetComponent<AudioSource>().PlayOneShot(throwsound);
        Rigidbody newcoconut = Instantiate(coconut_bl, transform.position, transform.rotation) as Rigidbody;
        newcoconut.velocity = transform.forward * 30.0f;
        canthrow = true;
        newcoconut.name = "Coconut";
    }
}
