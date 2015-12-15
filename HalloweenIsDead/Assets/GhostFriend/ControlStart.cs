using UnityEngine;
using System.Collections;

public class ControlStart : MonoBehaviour
{
   private PlayerController FlipController;
    public GameObject startMove;
    void Start()
    {
        FlipController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "moveStartTrigger")
        {
            FlipController.enabled = true;
        }

    }
}
