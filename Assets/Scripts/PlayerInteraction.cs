using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    private float _maxDistance;
    private IUsable _target;

    public Camera _camera;
    public Image _spriteToChange;
    private PlayerMove _playerMove;

    private void Awake()
    {
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        _spriteToChange = GameObject.Find("Crosshair").GetComponent<Image>();
        _playerMove = GetComponent<PlayerMove>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        FindTarget();
        UseTarget();
        ChangeCrossHairState();
    }

    void FixedUpdate()
    {
        _playerMove.Move();
    }


    private void FindTarget()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {

            }
        }

    }

    private void UseTarget()
    {
        //si input button
        //if (Input.getButtonDown)
    }
    
    private void ChangeCrossHairState()
    {
        //change couleur
        //Color colortochange = target.GetComponent<Image>().color;
    }
}
