using UnityEngine;

public class PlayerMovements : MonoBehaviour {

    public Rigidbody rb;

    public float jumpForce;
    public float sideForce;

    private bool canJump = false;

	// Use this for initialization
	void Start () {
        
	}

    // FixedUpdate is called once per frame to manage physics
    void FixedUpdate () {
        if(Input.GetKey("q")){
            rb.AddForce(- sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("space") && canJump)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            canJump = false;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
}
