using System.Collections.Generic;
using UnityEngine;

public class Filth : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
