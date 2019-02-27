﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    private Vector3 cameraRotation = Vector3.zero;

    private PlayerMotor motor;

	// Use this for initialization
	void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Calculate movement velocity as a 3D vector
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        // Final movement vector 
        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        // Calculate rotation as a 3D vector
        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        // Apply movement
        motor.Move(_velocity);

        // Apply rotation
        motor.Rotate(_rotation);

        // Calculate camera rotation as a 3D vector (turning around)
        float _xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * lookSensitivity;

        // Apply Movement
        motor.Move(_velocity);

        // Apply Rotation
        motor.Rotate(_rotation);

        // Apply Camera Rotation
        motor.RotateCamera(_cameraRotation);


    }
}
