using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public AudioClip clip; 

    private AudioSource audioSource;
    private int score;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Puck")){
            audioSource.PlayOneShot(clip);
            scoreText.text = (++score).ToString("D2");

            collision.transform.position = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
