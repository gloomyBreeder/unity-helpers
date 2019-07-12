﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> Pretty simple script for Camera to follow your player </summary>
public class CameraController : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public bool UseOffsetValues;
    void Start()
    {
        if (!UseOffsetValues)
        {
            Offset = Target.position - transform.position;
        }
    }

    void Update()
    {
        transform.position = Target.position - Offset;
        transform.LookAt(Target);
    }
}
