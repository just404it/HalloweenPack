using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    Camera mainCam;
    public float rotator;


    public GameObject player;

    private Vector3 offset;

    void Start()
    {
       // mainCam = Camera.main;
        offset = transform.position - player.transform.position;
    }
    void Update()
    {
       // transform.Translate(Vector3.right * Time.deltaTime);
        //mainCam.transform.rotation = Quaternion.Euler(0f, 0f, rotator);

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}