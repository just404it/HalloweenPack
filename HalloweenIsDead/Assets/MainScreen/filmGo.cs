using UnityEngine;
using System.Collections;

public class filmGo : MonoBehaviour
{

    public MovieTexture video;
    public float Timer = 0f;

    // Use this for initialization
    void Start()
    {
        video = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
        // this line of code will make the Movie Texture begin playing
        video.Play();
        video.loop = true;
    }

    void Update()
    {


        Timer += Time.deltaTime;

        if (Timer > 35f)
        {
            //video.loop();
            //video = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
            //video.Play();
            Timer = 0f;
            // Application.LoadLevel(1);
        }
    }
}
