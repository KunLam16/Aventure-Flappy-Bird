using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Level2 : MonoBehaviour
{

    public GameObject pipe;
    public GameObject bird;
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bird.GetComponent<Bird>().score >= 0 && bird.GetComponent<Bird>().score < 8)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 2.5f;
            pipe.GetComponent<Pipe>().speed = 4.0f;
        }
        if (bird.GetComponent<Bird>().score >= 8 && bird.GetComponent<Bird>().score < 16)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 2.0f;
            pipe.GetComponent<Pipe>().speed = 5.0f;
        }
        if (bird.GetComponent<Bird>().score >= 16 && bird.GetComponent<Bird>().score < 24)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 1.5f;
            pipe.GetComponent<Pipe>().speed = 6.0f;
        }
        if (bird.GetComponent<Bird>().score >= 24 && bird.GetComponent<Bird>().score < 32)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 1.25f;
            pipe.GetComponent<Pipe>().speed = 7.0f;
        }
        if (bird.GetComponent<Bird>().score >= 32 && bird.GetComponent<Bird>().score < 46)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 1f;
            pipe.GetComponent<Pipe>().speed = 7.5f;
        }
        if (bird.GetComponent<Bird>().score >= 46)
        {
            gameController.GetComponent<PipeGene>().timeDuration = 0.75f;
            pipe.GetComponent<Pipe>().speed = 8.0f;
        }
    }
}

