﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (0f, 1f, 0f, Space.World);
	}
}
