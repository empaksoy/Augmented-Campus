using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	public float speed = 5.0f;
	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = new Vector3(transform.position.x-0.01f,transform.position.y,transform.position.z);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = new Vector3(transform.position.x+0.01f,transform.position.y,transform.position.z);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+0.01f);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-0.01f);

		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position = new Vector3(transform.position.x,transform.position.y+0.01f,transform.position.z);

		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			transform.position = new Vector3(transform.position.x,transform.position.y-0.01f,transform.position.z);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up, 5);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.up, -5);
		}
		if (Input.GetKey (KeyCode.R)) {
			Vector3 tmp = transform.eulerAngles;
			tmp.y = 175;
			transform.eulerAngles = tmp;
		}
		if(Input.GetKey(KeyCode.Z))
		{
			transform.position = startPosition;
		}
	}
}
//*(Mathf.Cos(transform.eulerAngles.y)