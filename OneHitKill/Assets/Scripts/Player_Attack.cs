using UnityEngine;
using System.Collections;

public class Player_Attack : MonoBehaviour {

    public GameObject sword;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(sword, transform.position + transform.forward, transform.rotation);
        }
    }
}
