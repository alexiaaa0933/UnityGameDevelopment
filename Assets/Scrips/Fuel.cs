using UnityEngine;
using TMPro;
using System;
public class Fuel : MonoBehaviour
{
    public int jumpsRemaining = 15;
    [SerializeField]
    private TextMeshProUGUI jumpsText;
    private void Start()
    {
        UpdateJumpsText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fuel"))
        {
            jumpsRemaining = jumpsRemaining + 5;

            UpdateJumpsText();
            Destroy(other.gameObject);
        }
    }
  
    public void UpdateJumpsText()
    {
        string text = "Remainig Jumps: " + jumpsRemaining.ToString();
        jumpsText.text = text;
    }
}
