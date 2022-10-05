using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class startLayer : MonoBehaviour{ 
    private bool AudioEnd = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartApplication();
        }

        if (!this.GetComponent<AudioSource>().isPlaying && AudioEnd)
        {
            SceneManager.LoadScene("MainScene");
        }

    }

    private void StartApplication()
    {
        this.GetComponent<AudioSource>().Play();
        AudioEnd = true;

    }
}
