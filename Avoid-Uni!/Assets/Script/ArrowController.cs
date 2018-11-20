/*
 *		CopyRight : Dev.Alter0
 *		https://github.com/hackplayerz
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {
	GameObject Player = null;
	SetPointController pointCtrl = null;

	void Start () {
		Player = GameObject.Find ("Player");
		pointCtrl = GameObject.FindGameObjectWithTag ("GameController").GetComponent<SetPointController> ();
	}
	void Update () {
		transform.Translate (0,pointCtrl.EnemeySpeed, 0);
		if (transform.position.y < -.7f) {
			Destroy (gameObject);
			pointCtrl.GetPoint ();
		}
	}
}
