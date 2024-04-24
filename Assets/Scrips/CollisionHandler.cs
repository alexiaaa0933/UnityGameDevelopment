using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField]
    private SoundManager _soundManager;
    [SerializeField]
    private ParticleSystem _particleSystem;
    private bool isParticleSystemPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            _soundManager.PlayFallingSound();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Planet" || collision.gameObject.tag == "Obstacle")
        {
            _particleSystem.Play();
            isParticleSystemPlaying = true;

            _soundManager.PlayFallingSound();
            StartCoroutine(WaitForParticleSystemToEndAndResetLevel());
        }

        if (collision.gameObject.tag == "Finish")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            _soundManager.PlaySuccessSound();
        }
    }
    private IEnumerator WaitForParticleSystemToEndAndResetLevel()
    {
        while (isParticleSystemPlaying)
        {
            if (!_particleSystem.isPlaying)
            {
                isParticleSystemPlaying = false;
            }
            yield return null;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}