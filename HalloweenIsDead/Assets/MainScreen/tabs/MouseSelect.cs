using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour
{
    public GameObject On;
    public string LevelSelect;
    void OnMouseOver()
    {
        On.SetActive(true);

     }
    void OnMouseExit()
    {
        On.SetActive(false);
    }
    void OnMouseDown()
    {
        Application.LoadLevel(LevelSelect);
    }

}