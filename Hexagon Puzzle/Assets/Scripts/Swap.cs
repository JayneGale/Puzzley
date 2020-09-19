using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour, IActivatable
{
    public GameObject swapTarget;

    public void Activate()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = swapTarget.transform.position;
        transform.position = endPos;
        transform.Rotate(0, 180, 0);
        swapTarget.transform.position = startPos;
        swapTarget.transform.Rotate(0, 180, 0);

    }
}
