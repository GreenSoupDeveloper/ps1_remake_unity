using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class start : MonoBehaviour
{
    public GameObject sony;
    public GameObject playstation;
    public AudioClip starty;
    public AudioClip end;
    public AudioSource src;
    public GameObject black;
    public GameObject debugcam;

    public int time;
    // Start is called before the first frame update
    void Start()
    {
        playstation.SetActive(false);
        sony.SetActive(false);
        black.SetActive(true);
        debugcam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = Random.RandomRange(8, 11);
            playstation.SetActive(false);
            sony.SetActive(true);
            src.PlayOneShot(starty);
            black.SetActive(false);
            Invoke("gameload", time);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            debugcam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            debugcam.SetActive(false);
        }
    }

    void gameload()
    {
        sony.SetActive(false);
        playstation.SetActive(true);
        src.PlayOneShot(end);

    }
}
