using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float gravityScale = 1f;
    public bool inPlayer = false;
    private Rigidbody rb;
    private EnemyCharacter enemyScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            inPlayer = true;
            enemyScript = collider.gameObject.GetComponent<EnemyCharacter>();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        inPlayer = false;
        enemyScript = null;
    }

    void Update()
    {

        if (inPlayer && Input.GetKeyDown(KeyCode.Space) && enemyScript != null)
        {
            enemyScript.TakeDamage(1); 
        }
    }
}
