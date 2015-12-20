using UnityEngine;
using System.Collections;

public class SelectCostume : MonoBehaviour 
{
	public string triggerName;
	public GameObject catObject;
	public GameObject box;
//	public bool isLeft;
//	public bool isRight; 
	Animator catAnimator;
	Animator boxAnimator;
	public float waitTime = .5f;
	bool timer;
	float i;

	void Awake()
	{
		catAnimator = catObject.GetComponent<Animator>();
		boxAnimator = box.GetComponent<Animator>();
//		boxAnimator.SetBool("RightBox", isRight);
//		boxAnimator.SetBool("LeftBox", isLeft);
	}
	void Update()
	{
		if (timer)
		{
		
			i -= Time.deltaTime;
			print(i);

			if ( i < 0 )
			{
				catAnimator.SetTrigger(triggerName);
				boxAnimator.SetTrigger("Use"); 
				timer = false;
			}
		}
	}
	void OnMouseUp() 
	{
		timer = true;
		i = waitTime;
	}

}
