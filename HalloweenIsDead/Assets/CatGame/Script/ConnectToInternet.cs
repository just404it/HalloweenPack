using UnityEngine;
using System.Collections;

public class ConnectToInternet : MonoBehaviour 
{
	private float timer = 0; 
	public float timerLimit = 15.6f ; 
	private bool startTimer = false;
	public string levelToLoad; 

	void Update()
	{
		if (startTimer == true)
		{
			timer += Time.deltaTime; 
			print (timer);
		}
		if (timer > timerLimit)
		{
			print("loadLEVEL!!!");
			startTimer = false;
			Application.LoadLevel(levelToLoad);
		}
	}

	void OnMouseDown() 
	{
		//Application.LoadLevel("NextLevel");
		startTimer = true;
		print("I Ran");
		GetComponent<AudioSource>().Play();
	}
}
