using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem particleSystem;

    public void StartBlasting()
    {
        particleSystem.Play();
    }

    public void StopBlasting()
    {
        particleSystem.Stop();
    }
}
