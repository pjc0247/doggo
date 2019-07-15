using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    public int hp = 10;

    public void Jump()
    {
        Debug.Log("JUMP");
    }

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        DoggoScript.Run("$(Player).hp = 20;");
    }
}
