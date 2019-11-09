using System.Collections;
using UnityEngine;

///<summary>
///
///</summary>

public class PlayerCollision : MonoBehaviour
{
    bool doorisopen = false;
    public AudioClip door_open_sound;
    public AudioClip door_shut_sound;
    float doorTimer = 0.0f;
    float dooropentime = 3.0f;
    GameObject currentDoor;
    void Start() {

    }
    void Update() {
        if (doorisopen){
            doorTimer += Time.deltaTime;
            if (doorTimer > dooropentime) {
                door(false, door_shut_sound, "doorClose", currentDoor);
                doorTimer = 0.0f;
            }
        }
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag == "playerdoor" && doorisopen == false) {
            currentDoor = hit.gameObject;
            door(true, door_open_sound, "doorOpen", currentDoor);
        }
    }
    void door(bool doorcheck, AudioClip a_clip, string anim_name, GameObject thisdoor) {
        doorisopen = doorcheck;
        thisdoor.transform.GetComponent<AudioSource>().PlayOneShot(a_clip);
        thisdoor.transform.parent.GetComponent<Animation>().Play(anim_name);
    }
}
