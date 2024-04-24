using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed;
    [SerializeField]
    private SoundManager _soundManager;
    [SerializeField]
    private ParticleSystem _particleSystem;
    private Fuel fuel;

    // Start is called before the first frame update
    void Start()
    {
        fuel = GetComponent<Fuel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && fuel.jumpsRemaining > 0)
        {
            transform.position += new Vector3(0, 1.5f * _MoveSpeed * Time.deltaTime, 0);
            fuel.jumpsRemaining--;
            fuel.UpdateJumpsText();
            _particleSystem.Play();
            _soundManager.PlayImpulseSound();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f * _MoveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f * _MoveSpeed * Time.deltaTime, 0, 0);
        }

    }
}
