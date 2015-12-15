using UnityEngine;
using System.Collections;

public class CameraSpin : MonoBehaviour
{
    public float spinSpeed;
    public static float contSpin;
    //void Awake()
    //{
    //    DontDestroyOnLoad(transform.gameObject);
   // }
    void Start()
    {
       // DontDestroyOnLoad(transform.gameObject);

    }
   
    void Update()
    {
        contSpin = spinSpeed * -Time.deltaTime;
        transform.Rotate(0, 0, contSpin);
       // transform.Rotate(0, Time.deltaTime, 0, Space.World);
    }
    
}