using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	bool isGrounded = false;
	bool doubleJump = false;
	int jumpcount = 0;

	float speed = 5.0f;

	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3(Input.GetAxis("Horizontal") * 10, rigidbody2D.velocity.y, 0);
			move = transform.TransformDirection(move);

			//rigidbody2D.AddRelativeForce(move * 30);// = move * speed * Time.deltaTime;
			rigidbody2D.velocity = move;

			//transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.UpArrow) &&  jumpcount < 2)
		{
			jumpcount++;

			Vector3 jumpforce = new Vector3(rigidbody2D.velocity.x, 5, 0);
			//rigidbody2D.velocity.y = jumpforce;
			//rigidbody2D.AddRelativeForce(jumpforce);
			rigidbody2D.velocity = (jumpforce);




		}
	}

	void OnCollisionEnter2D(Collision2D theCollision){
		if(theCollision.gameObject.tag == "maa")
		{
			isGrounded = true;
			jumpcount = 0;
		}
	}
	

}
