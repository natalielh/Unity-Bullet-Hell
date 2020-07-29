using UnityEngine;
using System.Collections;

public class playerFlip2 : MonoBehaviour {

	public float playerPos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		if (mousePos.x < transform.position.x) {

			GetComponent<SpriteRenderer> ().flipX = true;

		}

		else {

			GetComponent<SpriteRenderer>().flipX = false;
		}


	}
}
