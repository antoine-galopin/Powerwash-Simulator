using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlaneFilth : MonoBehaviour
{
    [SerializeField] private ARPlane arPlane;
    [SerializeField] private GameObject filthPrefab;
    [SerializeField] private int filthScaler = 2;

    private bool initialized;
    private List<GameObject> filths = new List<GameObject>();

    void Start()
    {
        arPlane.boundaryChanged += ArPlaneChanged;    
    }

    private void ArPlaneChanged(ARPlaneBoundaryChangedEventArgs obj)
    {
        if (initialized)
        {
            return;
        }

        if (arPlane.alignment == UnityEngine.XR.ARSubsystems.PlaneAlignment.HorizontalUp)
        {
            initialized = true;

            Vector2 scaledSize = arPlane.size * filthScaler;

            for (int x = 0; x < scaledSize.x; x++)
            {
                for (int y = 0; y < scaledSize.y; y++)
                {
                    Vector3 positionOffset = new Vector3(x - scaledSize.x * 0.5f, 0, y - scaledSize.y * 0.5f) / filthScaler;

                    GameObject filthInstance = Instantiate(filthPrefab, transform);
                    filthInstance.transform.localPosition = positionOffset;
                    filths.Add(filthInstance);
                }
            }

        }
    }
}
