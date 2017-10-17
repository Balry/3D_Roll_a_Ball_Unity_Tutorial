using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float curBallSpeed;
    public Text countText;
    public Text vicText;

    private Rigidbody rb;
    private float ballSpeed;
    private int count;

	//Function is called on the first frame te script is active (usually the first frame of game)
    void Start() {
		rb = GetComponent<Rigidbody>();	//this accesses the Rigidbody component of the same game object
        ballSpeed = curBallSpeed;
        count = 0;
        SetCountText();
        vicText.text = "";
	}

	/* //This is called before rendering a frame
	void Update()
    {
        
    }
    */

	//This is called before performing any physics calculations
    void FixedUpdate()
    {
        /* Stops the ball immediately with the spacebar
        if (Input.GetKeyDown("Space"))
        {
            ballSpeed = 0.0f;
        }*/

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * ballSpeed, ForceMode.Force);

		/* Jumping ball failed attempt (TODO add jumping feature)
        if (Input.GetKeyUp("space") && ballSpeed == 0)
        {
            ballSpeed = curBallSpeed;
        }*/
    }

    void OnTriggerEnter(Collider other) 
    {
        //Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            vicText.text = "Victory!";
        }
                
    }
}