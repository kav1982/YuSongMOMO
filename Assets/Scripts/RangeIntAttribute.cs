using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_SEITOR
using UnityEditor;
#endif
public sealed class RangeIntAttribute : PropertyAttribute
{
    public readonly int min;

    public readonly int max;

    public RangeIntAttribute(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
}
