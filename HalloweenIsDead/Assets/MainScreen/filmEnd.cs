using UnityEngine;
using System.Collections;

public class filmEnd : MonoBehaviour
{

    public MovieTexture video;
    public float Timer = 0f;

    // Use this for initialization
    void Start()
    {
        video = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
        // this line of code will make the Movie Texture begin playing
        video.Play();
    }

    void Update()
    {


        Timer += Time.deltaTime;

        if (Timer > 21f)
        {
            Application.Quit();
        }
    }
}
