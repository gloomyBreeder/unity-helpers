using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> This script is an example how to use Singletons in Unity.
/// You can relate to them in any part of your code with word "instance" </summary>
public class BasicManager<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance;

    public virtual void Awake()
    {
        if (instance)
        {
            Debug.LogError("Duplicate subclass " + instance.name);
            Destroy(gameObject);
        }
        else
        {
            instance = this as T;
        }
    }

    public virtual void OnDestroy()
    {
        if (instance == this)
            instance = null;
    }
}