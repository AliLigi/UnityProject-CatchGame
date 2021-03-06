﻿using UnityEngine;
using System.Collections;

public class HatControler : MonoBehaviour {

	public Camera cam;
	private bool canControl;
	private float maxWidth;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
		canControl = false;
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		float hatWidth = renderer.bounds.extents.x;
		maxWidth = targetWidth.x - hatWidth;
	
	}
	
	// Update is called once per phisycs timestep
	void FixedUpdate () {
		if (canControl) {
			Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
			Vector3 targetPosition = new Vector3 (rawPosition.x, 0.0f, 0.0f);
			float targetWidth = Mathf.Clamp (targetPosition.x, -maxWidth, maxWidth);
			targetPosition = new Vector3 (targetWidth, targetPosition.y, targetPosition.z);
			rigidbody2D.MovePosition (targetPosition);
		}
	}
	public void ToggleControl (bool toggle) {
		canControl = toggle;
	}
}
