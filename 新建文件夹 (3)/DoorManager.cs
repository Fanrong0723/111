using System.Collections;
using UnityEngine;

///<summary>
///
///</summary>

public class DoorManager : MonoBehaviour
{
    bool doorisopen = false;
    public AudioClip door_open_sound;
    public AudioClip door_shut_sound;

    float doortimer = 0.0f;
    public float dooropentime = 3.0f;

    void Update()
    {
        if (doorisopen)
        {
            doortimer += Time.deltaTime;
            if (doortimer > dooropentime)
            {
                door(false, door_shut_sound, "doorClose");
                doortimer = 0.0f;
            }
        }
    }

    void doorcheck()
    {
        if (!doorisopen)
        {
            door(true, door_open_sound, "doorOpen");
            
        }
    }

    void door(bool doorcheck, AudioClip a_clip, string anim_name)
    {
        doorisopen = doorcheck;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(a_clip);
        this.gameObject.transform.parent.GetComponent<Animation>().Play(anim_name);
    }
}
