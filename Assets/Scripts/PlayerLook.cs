using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private Vector2 mouseSensitivity;
    private Vector2 pasSensitivity;
    private Vector2 mouseYLimit;

    private float _horizontal;
    private float _vertical;

    private void Awake()
    {

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


        _horizontal += mouseX;
        _vertical += Mathf.Clamp(_vertical, mouseYLimit.x, mouseYLimit.y);

    }
}
