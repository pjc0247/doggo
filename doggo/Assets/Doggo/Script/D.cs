using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class D : MonoBehaviour
{
    public static T GetSingle<T>()
        where T : UnityEngine.Object
    {
        var t = GameObject.FindObjectOfType<T>();
        if (t == null)
            return default(T);
        return t;
    }
    public static T[] GetMultiple<T>()
        where T : UnityEngine.Object
    {
        var t = GameObject.FindObjectsOfType<T>();
        if (t == null)
            return new T[] { };
        return t;
    }
}