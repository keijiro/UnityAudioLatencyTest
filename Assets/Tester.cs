using UnityEngine;
using System.Collections;

public sealed class Tester : MonoBehaviour
{
    [field:SerializeField] public float Interval { get; set; } = 2;
    [field:SerializeField] public AudioClip Clip { get; set; }

    IEnumerator Start()
    {
        var source = GetComponent<AudioSource>();
        var camera = Camera.main;

        while (true)
        {
            yield return new WaitForSeconds(Interval);
            source.PlayOneShot(Clip);
            camera.backgroundColor = Color.white;
            yield return null;
            camera.backgroundColor = Color.black;
        }
    }
}
