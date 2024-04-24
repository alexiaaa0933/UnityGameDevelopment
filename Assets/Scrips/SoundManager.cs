using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip successSound;
    [SerializeField]
    private AudioClip impulseSound;
    [SerializeField]
    private AudioClip fallingSound;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    public void PlaySuccessSound()
    {
        audioSource.PlayOneShot(successSound);
    }
    public void PlayImpulseSound()
    {
        audioSource.PlayOneShot(impulseSound);
    }
    public void PlayFallingSound()
    {
        audioSource.PlayOneShot(fallingSound);
    }
}
