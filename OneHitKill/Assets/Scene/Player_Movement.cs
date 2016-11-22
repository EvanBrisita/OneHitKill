using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;
    public float dir;

    // Use this for initialization
    void Start () {
        speed = 5;
        dir = 0;
        

    }
	
	// Update is called once per frame
	void Update () {
        // Move the player based on controller input and check if controller input
        // is greater than a certain threshold
        if (Mathf.Abs(Input.GetAxis("Horizontal")) >= .19 
            || Mathf.Abs(Input.GetAxis("Vertical")) >= .19)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed*(Input.GetAxis("Horizontal")),
                speed*(Input.GetAxis("Vertical")));

            dir = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * Mathf.Rad2Deg;
            GetComponent<Rigidbody2D>().transform.rotation = Quaternion.AngleAxis(dir, Vector3.forward);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
        
        
    }
}
