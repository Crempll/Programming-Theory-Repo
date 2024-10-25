using System;
using System.Collections;
using UnityEngine;

public static class RotateShape
{
    public static void RotateThisShape(Transform transformShape)
    {
        transformShape.Rotate(Vector3.forward * 100f * Time.deltaTime);
    }
}
