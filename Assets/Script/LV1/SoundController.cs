using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    //design pattern: tạo một biến có phạm vi truy cập tại mọi nơi
    public static SoundController instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlayThisSound(string clipName, float amLuong)
    {
        AudioSource audioSource = this.gameObject.AddComponent<AudioSource>();
        audioSource.volume *= amLuong;
        audioSource.PlayOneShot((AudioClip)Resources.Load("Music/" + clipName,typeof(AudioClip)));
    }    
}
