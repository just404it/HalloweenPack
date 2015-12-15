using UnityEngine;
using System.Collections;

public class tear_maker : MonoBehaviour
{
    public GameObject tear;
    public GameObject Skeleton;
    // public float tearTimer = 0.5f;
    bool tearRun = false;
    public float tearFlood = 1;
    public float tearNeed = 1;
    Animator Susan;

    // Update is called once per frame
    void Start()
    {
        Susan = Skeleton.GetComponent<Animator>();
    }

    void Update()
    {
        if (tearFlood > tearNeed && (Input.anyKey))
        {
            Rigidbody clone;
            clone = Instantiate(tear, transform.position, transform.rotation) as Rigidbody;
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            tearFlood = 0;
            tearRun = true;
            print(tearFlood);
 
        }
        if (Input.anyKey)
        {
            Susan.SetBool("tearBool", true);
        }
        else if (!Input.anyKey)
        {
            Susan.SetBool("tearBool", false);
        }
        tearFlood += 1f * Time.deltaTime;

    }
}