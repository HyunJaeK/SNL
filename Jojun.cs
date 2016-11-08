using UnityEngine;
using System.Collections;

public class Jojun : MonoBehaviour {

	public Transform jjojun;
	RaycastHit Hit;
	// Use this for initialization
	public IEnumerator JoJunHam(){
		Physics.Raycast (jjojun.position, jjojun.forward, out Hit, 10000f);
		if(Hit.collider)
		{
			if(Hit.collider.tag == "Monster")
			{
				Destroy(Hit.collider.gameObject);
			}
		}
		yield return null;
	}
}
