using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    public AudioClip collectSound;
    public static int charge = 0;
    public Texture2D[] powerTextures;
    public RawImage powerGUI_bl;
    public Texture2D[]chargemeterTexrure;
    public Renderer chargemeter_bl;



    // Use this for initialization
    void Start () {
        charge = 0;
        powerGUI_bl.enabled = false;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void CellPickUo() {
        charge++;
        powerGUI_bl.enabled = true;
        powerGUI_bl.texture = powerTextures[charge];
        chargemeter_bl.material.mainTexture = chargemeterTexrure[charge];
        AudioSource.PlayClipAtPoint(collectSound,transform.position);

    }
}
