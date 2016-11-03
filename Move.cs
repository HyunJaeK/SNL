using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    
    public CharacterController CC;
	Vector3 V3;
	float MoveSpeed;
	float TurnSpeed;

	// Use this for initialization
	void Start () {
		MoveSpeed = 7;
		TurnSpeed = 3f;
	
	}
	
	// Update is called once per frame
	void Update () {

		V3 = new Vector3 (0, Input.GetAxis ("Mouse X"), 0);
		transform.Rotate (V3 * TurnSpeed);

		if (Input.GetKey (KeyCode.W)) {
			CC.Move (transform.forward * MoveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			CC.Move (transform.forward * -1f * MoveSpeed * Time.deltaTime);
        }
		if (Input.GetKey (KeyCode.A)) {
			CC.Move (transform.right * -1f *MoveSpeed * Time.deltaTime);
        }
		if (Input.GetKey (KeyCode.D)) {
			CC.Move (transform.right * MoveSpeed * Time.deltaTime);
        }
	
	}
}
