using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {
    public GameObject levelChanger;
   public int i = Application.loadedLevel;
    // Use this for initialization
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
      // int i = Application.loadedLevel;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "levelChanger")
        {
            Application.LoadLevel(i + 1);
        }
    }
}
