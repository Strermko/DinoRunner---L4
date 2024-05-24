using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player characteristics")]
    [SerializeField] float jumpHeight = 5;

    [Header("Audio clips")]
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip landSound;

    private Rigidbody2D rigidbody2D;
    private AudioSource audioSource;
    private Animator animator;
    private bool isGrounded = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
           rigidbody2D.velocity = Vector2.up * jumpHeight;
           isGrounded = false;
           //What about jumping sound?
           audioSource.PlayOneShot(jumpSound);
        }

        if(rigidbody2D.velocity.y == 0 && !isGrounded){
            isGrounded = true;
            //Time for landing sound!
            audioSource.PlayOneShot(landSound);
        }

        //Add jumping animations
        animator.SetBool("IsGrounded", isGrounded);
    }
}
