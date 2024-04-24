using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
    [SerializeField]
    private float _ScaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.P))
            transform.localScale = new Vector3(
                               transform.localScale.x + _ScaleFactor,
                               transform.localScale.y + _ScaleFactor,
                               transform.localScale.z + _ScaleFactor);

        if (Input.GetKey(KeyCode.O))
            transform.localScale = new Vector3(
                               transform.localScale.x - _ScaleFactor,
                               transform.localScale.y - _ScaleFactor,
                               transform.localScale.z - _ScaleFactor);
    }
}
