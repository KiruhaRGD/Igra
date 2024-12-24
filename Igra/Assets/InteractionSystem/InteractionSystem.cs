using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private LayerMask layerMask;

    private Ray ray;
    private RaycastHit hit;

    void Update()
    {
        CheckInteraction();
    }

    private void CheckInteraction()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit, distance, layerMask))
        {
            if (!hit.collider.TryGetComponent(out NewBehaviourScript aaaaaaa)) return;

            if (Input.GetKeyDown(KeyCode.E)) {
                aaaaaaa.Interact();
            }

        }
    }
}
