using UnityEngine;
using System.Collections;

public class CatChatPlayer : MonoBehaviour 
{
	float xSpeed =0f;
	float ySpeed =0f;
	private Vector2 velo;
	public float moveSpeed;

	Animator animator;
	private Rigidbody2D rbCat; 

	// Use this for initialization
	void Awake () 
	{
		animator = this.gameObject.transform.GetChild(0).GetComponent<Animator>();
		rbCat = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float horz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		xSpeed = horz * moveSpeed;
		ySpeed = vert * moveSpeed;
		velo = new Vector2 (xSpeed, ySpeed);

		rbCat.MovePosition (rbCat.position + velo * Time.fixedDeltaTime);

		if (vert < 0) 
		{
			rbCat.MoveRotation(180);
		}
		else if (vert > 0) 
		{
			rbCat.MoveRotation(0);
		}
		if (horz > 0)
		{ 
			rbCat.MoveRotation (-90);
		}
		else if (horz < 0)
		{
			rbCat.MoveRotation (90);

		}
		if (vert !=0 || horz !=0)
		{
			animator.SetFloat("speed", moveSpeed);
		}
		else 
		{
			animator.SetFloat("speed", 0);
		}
	}
}
