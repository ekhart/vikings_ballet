using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public bool isStaringAtCollectable;

    private Renderer render;
    private Shader standard, outlined;
    private GameObject lastSeenGameObject;

	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
		standard = Shader.Find("Standard");
        outlined = Shader.Find("Outlined/Silhouette Only");
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        lastSeenGameObject = GameObject.FindWithTag("Collectable");

        if (Physics.Raycast (ray, out hit, 10f) && !isStaringAtCollectable) {
            lastSeenGameObject = hit.transform.gameObject;
            
            if (lastSeenGameObject.tag == "Collectable") {
                isStaringAtCollectable = true;
                lastSeenGameObject.GetComponent<Renderer>().material.shader = outlined;
            }

            // Debug.DrawRay (ray.origin, hit.point);
            // Debug.Log("Hit! at " + hit.point);
            // Debug.Log(hit);
            // Debug.Log(hit.transform.tag);

            //collectable.tag = "none";
            //hit.collider.transform.tag = "select";
        } else {
            isStaringAtCollectable = false;
            lastSeenGameObject.GetComponent<Renderer>().material.shader = standard;
        }


        if (Input.GetMouseButtonDown(0)){
            // todo: add to players inventory            
        }
	}
}
