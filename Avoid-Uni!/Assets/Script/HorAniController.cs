/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorAniController : MonoBehaviour {
	GameObject Player = null;
	SetPointController pointCtrl = null;

	void Start () {
		Player = GameObject.Find ("Player");
		pointCtrl = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SetPointController> ();
	}
	void Update () {
		transform.Translate (pointCtrl.EnemeySpeed * 1.5f, 0, 0);
		if (transform.position.x <-11.11f) {
			Destroy (gameObject);
			pointCtrl.GetPoint ();
		}
	}
}
