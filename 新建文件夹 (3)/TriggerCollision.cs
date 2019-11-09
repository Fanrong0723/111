using System.Collections;
using UnityEngine;
using UnityEngine.UI;
///<summary>
///
///</summary>

public class TriggerCollision : MonoBehaviour
{
    public Light doorlight_bl;
    public Text doorText_bl;
    bool isText = false;
    float doorTextTimer = 0.0f;
    public GameObject ob;
    void Update()
    {
        if (isText) {
            doorTextTimer += Time.deltaTime;
            if (doorTextTimer > 3.0f){

                isText = false;
                doorTextTimer = 0.0f;
                doorText_bl.text = "";
            }
        }
            
                }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Inventory.charge == 4)
            {
                doorlight_bl.color = Color.green;
                transform.Find("door").SendMessage("doorcheck");
                Destroy(ob);

            }
            
        else {
            if (!isText)
            {
                doorText_bl.text = "这扇门需要你搜集至少四个能量才能启动！";
                isText = true;
            }
        }
        }
    }
}
