using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

    public AudioSource AS;
    public GameObject FireEffects;
	public GameObject FireArmoEffects;
	public Transform FireArmoEffectsT;
    public Animator GunAny;
    public Animator CharacterAny;

	bool FireArmoEffectON = true;
	// Use this for initialization
	void Start () {
        FireEffects.SetActive(false);
	
	}

	// Update is called once per frame
	void Update () {
		if (!GunFire ())
			return;
	}
	bool GunFire(){
		if (Input.GetMouseButton(0))
		{
			GunAny.SetBool("Fire", true);
		}else if (Input.GetMouseButtonUp(0))
			GunAny.SetBool("Fire", false);
		return true;
	}

	public void GunFireONEvent(){
		FireEffects.SetActive (true);
		if (FireArmoEffectON)
			Instantiate (FireArmoEffects, FireArmoEffectsT.position, FireArmoEffectsT.rotation);
		AS.Play ();
		FireArmoEffectON = false;
	}
	public void GunFireOFFEvent(){
		FireArmoEffectON = true;
	}

		
}
