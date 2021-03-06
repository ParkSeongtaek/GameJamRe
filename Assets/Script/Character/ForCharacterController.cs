using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ForCharacterController : MonoBehaviour
{

    public Animator anim;

    Vector3 moveVector;
    Vector3 move;
    Vector3 startPos = new Vector3();
    Vector3 endPos;
    Vector3 velocity;

    //public float gravity = -9.8f;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    public bool isGrounded = true;
    public float jumpHeight = 200f; // JH: 4f->.7f

    public float yVelocity = 0;
    public float gravity = -30;
    public float jumpPower = 10f;
    public bool ReadyJump = false;


    float speed = 13.0f;
    public CharacterController controller;
    bool timerStart = false;
    bool returnPos = false;
    float timer = 0f;
    float time = 0.3f;          //Key
    bool jumpB = false;
    float jumpF = 18f;
    //Assign out controller
    void Start()
    {
        controller = GetComponent<CharacterController>();
        startPos = transform.position;
        endPos = transform.position + new Vector3(60, 0, 0);

        anim = GetComponent<Animator>();
        anim.SetInteger("playerWalk", 1);
    }


   
    void Update()
    {


        if (timerStart)
        {
            timer += Time.deltaTime;
        }

        if (returnPos)
        {


            move = transform.right;
            controller.Move(-move * speed * Time.deltaTime);

            if (startPos.x > transform.position.x)
            {
                Debug.Log(startPos.x + "   " + transform.position.x);
                returnPos = false;
            }
        }







        //REeset the MoveVector
        moveVector = Vector3.zero;

        //Check if cjharacter is grounded
        if (controller.isGrounded == false)
        {
            //Add our gravity Vecotr
            moveVector += Physics.gravity;
        }

        //Apply our move Vector , remeber to multiply by Time.delta
        controller.Move(moveVector * Time.deltaTime);



        if (GameManager.Instance.inGame)
        {
            if (Input.GetMouseButton(0))
            {
                returnPos = false;
                if (!timerStart)
                    timerStart = true;


                if (timer > time)
                {
                    jumpB = false;

                    move = transform.right;
                    if (transform.position.x < endPos.x)
                        controller.Move(move * speed * Time.deltaTime);


                }
            }
            if (Input.GetMouseButtonUp(0))
            {

                if (timer < time)
                {
                    jumpB = true;
                    anim.SetInteger("playerWalk",0);
                    anim.SetInteger("playerJump",1);

                }
                timerStart = false;
                timer = 0f;
                returnPos = true;

            }
        }

        //캐릭터 y값이 0보다 작을 때(지면에 닿을 때) playerWalk 파라미터를 1로 바꿈
        if(this.gameObject.transform.localPosition.y<=0)
        {
            anim.SetInteger("playerWalk",1);
        }

        if (jumpB && transform.position.y < -13)
        {
            velocity.y = 2f * Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpB = false;
        }

        velocity.y += 3f * gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        
    }

}