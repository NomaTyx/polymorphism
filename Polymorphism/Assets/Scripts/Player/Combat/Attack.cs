using System;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Console.WriteLine(other.name);
    }
}
