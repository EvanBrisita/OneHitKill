using UnityEngine;
using System.Collections;
using Rewired;

public class Player_Movement : MonoBehaviour {
    Rigidbody2D rb;
    public Player rePlayer;
    public float speed;
    public float boost;
    public float dir;

    // Use this for initialization
    void Start () {
        speed = 3;
        boost = 2.5f;
        dir = 0;
        rePlayer = ReInput.players.GetPlayer(0);
        

    }
	
	// Update is called once per frame
	void Update () {
        // Move the player based on controller input and check if controller input
        // is greater than a certain threshold
        if (Mathf.Abs(rePlayer.GetAxis("Horizontal")) >= .19 || Mathf.Abs(rePlayer.GetAxis("Vertical")) >= .19)
        {
            if(Input.GetAxis("Right Trigger") == 1)
            {
                // Set the velocity
                GetComponent<Rigidbody2D>().velocity = new Vector2( boost * speed * (rePlayer.GetAxis("Hor")),
                boost * speed * (Input.GetAxis("Ver")));
            }
            else
            {
                // Set the velocity
                GetComponent<Rigidbody2D>().velocity = new Vector2( speed * (Input.GetAxis("Hor")),
                speed * (Input.GetAxis("Ver")));
            }
            

            // Set the direction and rotaion
            dir = Mathf.Atan2(Input.GetAxis("Ver"), Input.GetAxis("Hor")) * Mathf.Rad2Deg;
            GetComponent<Rigidbody2D>().transform.rotation = Quaternion.AngleAxis(dir, Vector3.forward);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
        
        
    }
}
