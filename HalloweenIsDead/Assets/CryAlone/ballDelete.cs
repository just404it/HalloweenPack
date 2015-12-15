using UnityEngine;
using System.Collections;

public class ballDelete : MonoBehaviour {
    public GameObject skelpos;
    public float tearFall = 20f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(skelpos.transform.position, gameObject.transform.position) > tearFall)
            Destroy(gameObject);
    }
}
