using UnityEngine;
using System.Collections;
using GeekGame.Input;

public class CubeControl : MonoBehaviour {

	public float speed=.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(JoystickMove.instance.H,0f,JoystickMove.instance.V)*speed*Time.deltaTime);


		transform.LookAt(transform.position+new Vector3(JoystickRotate.instance.H,0f,JoystickRotate.instance.V));

		if(JoystickFire.instance.Fire){
			Debug.Log("fire");
		}
	}
}
