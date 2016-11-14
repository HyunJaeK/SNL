using UnityEngine;
using System.Collections;

public class GunEvent : MonoBehaviour {

	public GameObject GunObject;

	void GunEventON(){
		GunObject.GetComponent<Fire> ().GunFireONEvent ();
	}
	void GunEventOFF(){
		GunObject.GetComponent<Fire> ().GunFireOFFEvent ();
	}

}
