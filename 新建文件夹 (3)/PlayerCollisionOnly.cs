using System.Collections;
using UnityEngine;

///<summary>
///
///</summary>

public class PlayerCollisionOnly : MonoBehaviour
{
    GameObject currentdoor;
	void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "playerdoor")
        {
            currentdoor = hit.gameObject;
            currentdoor.SendMessage("doorcheck");
        }
    }
}
