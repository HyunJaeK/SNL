using UnityEngine;
using System.Collections;

public class FireEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("OFF", 0.01f);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.SetActive (false);
	}
}
