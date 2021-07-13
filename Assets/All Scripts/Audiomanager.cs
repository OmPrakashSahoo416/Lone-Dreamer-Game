using UnityEngine;
using UnityEngine.Audio;
using System;

[System.Serializable]
public class sound {

    public string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3f)]
    public float pitch;
    public bool loop;

    [HideInInspector]
    public AudioSource source;

    }
public class Audiomanager : MonoBehaviour
{
    
    public sound[] sounds;
    private void Awake()
    {
        foreach (sound s in sounds ) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name) {

        sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
      
    }
        
}
