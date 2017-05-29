﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep : MonoBehaviour {

	private static bool objectExists;

	// Use this for initialization
	void Start () {
		if (!objectExists) {
			objectExists = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
}
