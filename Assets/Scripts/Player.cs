using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public Rigidbody2D rb;
	private Vector3 startPos;

	// Use this for initialization
	void Start ()
	{
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.bodyType = RigidbodyType2D.Dynamic;
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			rb.bodyType = RigidbodyType2D.Static;
			transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
			transform.position = startPos;
		}
	}
}
