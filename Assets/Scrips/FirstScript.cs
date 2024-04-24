using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _Rigidbody;

    [SerializeField]
    private float _Force=100;

    private float _xScaleFactor;
    [SerializeField]
    private float _YScaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        _xScaleFactor = 2.0f;
        Debug.Log($"{_xScaleFactor}, {_YScaleFactor}");

        transform.localScale = new Vector3(
            transform.localScale.x * _xScaleFactor,
            transform.localScale.y* _YScaleFactor, 
            transform.localScale.z);

        transform.position = new Vector3(0, 0, 1);
        transform.rotation = Quaternion.Euler(0, 0, 45);

    }

    // Update is called once per frame
    void Update()
    {
        //move the object with mouse left click
        if (Input.GetMouseButton(0))
        {
            float distance_to_screen = 
                Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = 
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 
                Input.mousePosition.y, 
                distance_to_screen));
        }
    }


}
