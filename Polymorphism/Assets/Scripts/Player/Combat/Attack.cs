using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private float attackDuration = 0.5f;
    private SphereCollider _collider;

    public void Start()
    {
        _collider = GetComponent<SphereCollider>();
    }

    public void DoAttack()
    {
        StartCoroutine(AttackCoroutine());
    }

    public void OnTriggerEnter(Collider other)
    {
        Console.WriteLine(other.name);
    }
    
    private IEnumerator AttackCoroutine()
    {
        _collider.enabled = true;
        yield return new WaitForSeconds(5);
        _collider.enabled = false;
    }
}
