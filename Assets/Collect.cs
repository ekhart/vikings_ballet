﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            if (Input.GetMouseButtonDown(0)){
                RaycastHit hit;
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                var select = GameObject.FindWithTag("Collectable").transform;

                if (Physics.Raycast (ray, out hit, 10f)){
                    Debug.DrawRay (ray.origin, hit.point);
                    Debug.Log("Hit! at " + hit.point);
                    //select.tag = "none";
                    Debug.Log(hit);
                    Debug.Log(hit.transform.tag);
                    //hit.collider.transform.tag = "select";
                }
            }
		
	}
}
