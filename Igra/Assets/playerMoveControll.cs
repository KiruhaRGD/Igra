using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveControll : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float smoothTime;
    private CharacterController characterController;
    private Vector3 _currentVelocity;
    private Vector3 smoothDamp;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 playerInput = new Vector3(x, 0, z);

        Vector3 moveVector = transform.TransformDirection(playerInput).normalized;

        _currentVelocity = Vector3.SmoothDamp(_currentVelocity, moveVector * speed, ref smoothDamp, smoothTime);

        characterController.Move(_currentVelocity * Time.deltaTime);

        //characterController.Move();
        //Vector2 direction = new Vector2()
    }
}
