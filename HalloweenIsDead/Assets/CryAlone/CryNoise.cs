using UnityEngine;
using System.Collections;

public class CryNoise : MonoBehaviour {
    public AudioClip cry;
    private AudioSource source;
   // public float AudioSource.volume;
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.clip = cry;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            // AudioSource.volume = 1; 

            if (!source.isPlaying)
             source.Play();
            
            // else source.Stop();
            //if (!Input.anyKeyDown)
            // source.Stop();
        }
        if (Input.anyKey == false)
        {
            source.Stop();
        }
    }
}
