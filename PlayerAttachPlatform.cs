using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Easy way for moving platforms if your character has Character Controller. This script keeps your character on platform by parenting it.
/// Put it on your platform which should also have 2 colliders: basic one and one with IsTrigger checked </summary>
public class PlayerAttachPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>() != null)
        {
            other.transform.SetParent(transform, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CharacterController>() != null)
        {
            other.transform.SetParent(null, true);
        }
    }
}
