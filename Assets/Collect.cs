using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public bool isStaringAtCollectable;

    private Shader standard, outlined;

	// Use this for initialization
	void Start () {
		standard = Shader.Find("Standard");
        outlined = Shader.Find("Outlined/Silhouette Only");
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var collectable = GameObject.FindWithTag("Collectable").transform;

        if (Physics.Raycast (ray, out hit, 10f) && !isStaringAtCollectable) {
            isStaringAtCollectable = true;
            // renderer.material.shader = outlined;

            // Debug.DrawRay (ray.origin, hit.point);
            // Debug.Log("Hit! at " + hit.point);
            // Debug.Log(hit);
            // Debug.Log(hit.transform.tag);

            //collectable.tag = "none";
            //hit.collider.transform.tag = "select";
        } else {
            isStaringAtCollectable = false;
            // renderer.material.shader = standard;
        }


        if (Input.GetMouseButtonDown(0)){
            // todo: add to players inventory            
        }
	}
}
