using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayRandomSound : MonoBehaviour
{
    public AudioClip[] sounds;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void Play()
    {
        var index = Random.Range(0, sounds.Length);
        source.clip = sounds[index];
        source.Play();
    }
}
