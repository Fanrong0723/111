using System.Collections;
using UnityEngine;

///<summary>
///
///</summary>

public class RaycastCollision : MonoBehaviour
{
    void Start() {
    }
    void Update() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5.0f)) {
            if (hit.collider.gameObject.tag == "playerdoor") {
                hit.collider.gameObject.SendMessage("doorcheck");
            }
        }
    }
}
