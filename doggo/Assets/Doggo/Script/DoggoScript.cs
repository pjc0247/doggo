using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Slowsharp;

public class DoggoScript : MonoBehaviour
{
    public static void Run(string script)
    {
        script = Preprocess(script);

        Debug.Log(script);

        Debug.Log(D.GetSingle<Player>().hp);

        var r = CScript.CreateRunner();
        var ret = r.Eval(script);

        Debug.Log(ret.ToString());
    }

    private static string Preprocess(string script)
    {
        var regex = new Regex("\\$\\(([a-zA-Z0-9_]+)\\)(.+);");
        var matches = regex.Matches(script);
        script = regex.Replace(script, $"foreach (var __c in D.GetMultiple<$1>()) {{ __c$2; }}");

        regex = new Regex("\\#\\(([a-zA-Z0-9_]+)\\)");
        matches = regex.Matches(script);
        return regex.Replace(script, $"D.GetSingle<$1>()");
    }
} 
