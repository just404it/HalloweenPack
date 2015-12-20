using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CatChat : MonoBehaviour 
{
	public GameObject[] chatterObject;
	public GameObject[] messageObject;
	public GameObject[] userObject; 
	private int i ;
	private float j, r;
	public string[] chatterNames; 
	public string[] userNames;
	public string[] messages; 
	private float waitTimeForText;
//	private float waitChatterGo;
	public GameObject inputObject; 

	void Awake()
	{

		for (i = 0; i < 6; i++)
		{
			j = Mathf.Round(Random.Range(1, 11));

			chatterObject[i].GetComponent<Text>().text = chatterNames[ (int)j];
			messageObject[i].GetComponent<Text>().text = messages[ (int)j ];
			userObject[i].GetComponent<Text>().text = userNames [ i ];
		}
//		waitChatterGo = 
		waitTimeForText = Random.Range(2.0f , 7.0f); 
	}
//	void OnGUI()
//	{
//		string textFieldString = "blah blah";
//		textFieldString = GUI.TextField (new Rect (500, 25, 100, 30), textFieldString, 25);
//
//	}
	void Update () 
	{
		j = Mathf.Round(Random.Range(1, 11));
		r = Mathf.Round(Random.Range(1, 11));

		if (Input.GetKeyDown("return"))
		{
			Invoke("SwitchySwitchUserInput", 0.5f);
			inputObject.GetComponent<InputField>().text = "";
		}
	}
	void FixedUpdate()
	{
		waitTimeForText -= Time.fixedDeltaTime;
		if (waitTimeForText < 0)
		{
			SwitchySwitchy();
			waitTimeForText = Random.Range(2.0f , 5.5f); 

		}
//		waitChatterGo -= Time.fixedDeltaTime;
//		if (waitChatterGo < 0)
//		{
//			print ("blah blah");
//			SwitchUsers();
//			waitChatterGo = Random.Range(10, 30);
//		}
	}
	void SwitchySwitchy()
	{
		for (i = 0; i < 5; i++)
		{
			messageObject[i].GetComponent<Text>().text = messageObject[i + 1].GetComponent<Text>().text;
			chatterObject[i].GetComponent<Text>().text = chatterObject[i + 1].GetComponent<Text>().text;
		}
		messageObject[5].GetComponent<Text>().text = messages[ (int)j ]; 
		chatterObject[5].GetComponent<Text>().text = chatterNames[ (int)r ];
		GetComponent<AudioSource>().Play();
	}
	void SwitchySwitchUserInput()
	{
		for (i = 0; i < 5; i++)
		{
			messageObject[i].GetComponent<Text>().text = messageObject[i + 1].GetComponent<Text>().text;
			chatterObject[i].GetComponent<Text>().text = chatterObject[i + 1].GetComponent<Text>().text;
		}
		messageObject[5].GetComponent<Text>().text = messages[ (int)j ]; 
		chatterObject[5].GetComponent<Text>().text = "<CatRqt>";
		GetComponent<AudioSource>().Play();
	}
//	void SwitchUsers()
//	{
//		int switchInt = Random.Range (0,6);
//	}
}
