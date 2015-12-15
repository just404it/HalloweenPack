using UnityEngine;
using System.Collections;

public class quitBackToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            if (Application.loadedLevelName == "mainScreen")
                Application.Quit();
            else
                Application.LoadLevel("mainScreen");
        }

        if (Input.GetKey("backspace"))
        {
            if (Application.loadedLevelName == "mainScreen")
                Application.Quit();
            else
                Application.LoadLevel("mainScreen");
        }

        /*
         if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (Input.GetKey("backspace"))
        {
            Application.LoadLevel("mainScreen");
        }
*/
    }
}
