using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public int speed;

    private void Start()
    {
        if (target == null)
        {
            target = gameObject.transform;
        }
    }

    private void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
