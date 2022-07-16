using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

  private Rigidbody2D playerBody;
    // Start is called before the first frame update
    public AudioClip clip;
    public AudioSource audioSource;

    public Transform Checker;
    public float RadioDeChecker; 
    public bool TocandoElPiso; 
    public LayerMask QueEsPiso;
    public GameObject  Player;
    private Animator animator;

   private void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
         
    }

   

    // Update is called once per frame
   private void Update()
    {
      //Input de Movimiento del jugador
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("horizontal", Mathf.Abs(horizontalInput));
        var horizontalSpeed = (horizontalInput*5.0f);

        playerBody.velocity = new Vector2(horizontalSpeed,playerBody.velocity.y);
        if (Input.GetButton("Jump") && TocandoElPiso == true){
          playerBody.velocity = new Vector2(horizontalSpeed,5.0f);
          audioSource.PlayOneShot(clip,0.5f);
          }
         
          TocandoElPiso = Physics2D.OverlapCircle(Checker.position,RadioDeChecker,QueEsPiso);
        
    }
}
