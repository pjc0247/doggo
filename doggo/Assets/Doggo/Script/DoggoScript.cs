using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Slowsharp;

public class DoggoScript : MonoBehaviour
{
    public static void Run(string script)
    {
        var r = CScript.CreateRunner("");
        var ret = r.Eval(script);

        Debug.Log(ret.ToString());
    }
} 
