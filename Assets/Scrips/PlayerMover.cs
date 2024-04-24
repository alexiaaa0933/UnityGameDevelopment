using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private float _MovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xHorizontal = (float)Input.GetAxis("Horizontal");
        float zVertical = (float)Input.GetAxis("Vertical");
        Vector3 moveSystem = new Vector3(xHorizontal, 0, zVertical);

        transform.Translate(moveSystem * _MovementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Translate(Vector3.up * _MovementSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.Q))
            transform.Translate(Vector3.down * _MovementSpeed * Time.deltaTime);

    }
}
