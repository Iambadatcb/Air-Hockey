using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    public AudioClip clip;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        audioSource.pitch = Random.Range(0.95f, 1.1f);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
