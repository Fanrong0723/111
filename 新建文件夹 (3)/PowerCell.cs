using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCell : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider col)

    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.SendMessage("CellPickUo");
            Destroy(this.gameObject);
        }
    }
}
    
