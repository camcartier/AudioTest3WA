using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Vector2 mouseSensitivity;
    private Vector2 padSensitivity;
    private Vector2 mouseYLimit;

    private float _rotationX = 0f;
    private float _rotationY = 0f;

    private float gamePadX;
    private float gamePadY;

    private Transform _cameraTransform;

    private void Awake()
    {
        _cameraTransform = GameObject.Find("Main Camera").transform;

        Cursor.lockState = CursorLockMode.Locked;
        mouseSensitivity = new Vector2(100, 100);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity.x * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity.y * Time.deltaTime;

        //float gamePadX = Input.GetAxis("RightHorizontal") * padSensitivity.x * Time.deltaTime;
        //float gamePadY = Input.GetAxis("RightVertical") * padSensitivity.y * Time.deltaTime;


        _rotationX += mouseX;
        _rotationY += mouseY;

        //empeche de regarder un angle trop grand en haut et en bas
        _rotationY = Mathf.Clamp(_rotationY, -90f, 90f);

        //la rotation du joueur en y n'influe pas la camera
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, _rotationX, transform.eulerAngles.z);

        _cameraTransform.eulerAngles = new Vector3(_rotationY, _cameraTransform.eulerAngles.y, _cameraTransform.eulerAngles.z);


        //transform.localRotation = Quaternion.Euler(_rotationX, _rotationY, 0f);
    }
}
