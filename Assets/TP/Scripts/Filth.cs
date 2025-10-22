using System.Collections.Generic;
using UnityEngine;

public class Filth : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        GameManager.Instance.IncrementScore();
        Destroy(gameObject);
    }
}
