namespace Game.player
{
    using Game.UI;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;

    public class PlayerView : MonoBehaviour
    {
        public Transform GroundCheck;
        public LayerMask GroundMask;


        private PlayerController playerController;

        [SerializeField]
        private float groundDistance = 0.4f;
        [SerializeField]
        private int speed;
        [SerializeField]
        private Vector3 velocity;
        [SerializeField]
        private float gravity;
        [SerializeField]
        private bool isGrounded;
        [SerializeField]
        private float jumpHeignt = 6f;



        private CharacterController characterController;
        private float verticalInput;
        private float horizontalInput;

        public int Healvalue;

        public void SetPlayerController(PlayerController Controller)
        {
            this.playerController = Controller;
        }
        void Start()
        {
            characterController = GetComponent<CharacterController>();
           
        }

        void Update()
        {
            Checks();
            HandleInput();
            Movement();
        }
        private void Checks()
        {
            isGrounded =Physics.CheckSphere(GroundCheck.position, groundDistance, GroundMask);
            if(isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }
        }
        private void HandleInput()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            if(Input.GetButtonDown("Jump") && isGrounded)
            {
                Jump();
            }
        }

        private void Jump()
        {
            velocity.y = Mathf.Sqrt(jumpHeignt * -2 * gravity);
        }

        private void Movement()
        {
            Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;
            characterController.Move(move * speed *Time.deltaTime);

            if (velocity.y > -10f)
            {
                velocity.y += gravity * Time.deltaTime;
            }
            

            characterController.Move(velocity *Time.deltaTime);
        }
        private void shoot()
        {

        }
        private void Death()
        {
            UIService.Instance.GameOver();
        }
        private void Collect()
        {

        }

        public void Heal()
        {
            //health ++
            UIService.Instance.Heal(Healvalue);
        }
    }
}