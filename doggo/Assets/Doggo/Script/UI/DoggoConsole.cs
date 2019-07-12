using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoggoConsole : MonoBehaviour
{
    public InputField scriptInput;

    public void OnClickEvaluate()
    {
        if (string.IsNullOrEmpty(scriptInput.text))
            return;

        DoggoScript.Run(scriptInput.text);
    }
}
