using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem particleSystem;

    [SerializeField]
    public int blastDelay = 5;

    public void StartBlasting()
    {
        StartCoroutine(WaitFiveSeconds());
    }

    IEnumerator WaitFiveSeconds()
    {
        // Wait for 5 seconds
        yield return new WaitForSeconds(blastDelay);

        particleSystem.Play();

        yield return new WaitForSeconds(particleSystem.main.duration);

        Destroy(gameObject);
    }
}
