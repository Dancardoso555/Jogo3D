using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class MenuController : MonoBehaviour 
{


    public VideoPlayer videoPlayer;
    public GameObject menuOpcoes;





    void Start()
    {

    }


    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            videoPlayer.Play();
            menuOpcoes.SetActive(true);
        }
    }

}


