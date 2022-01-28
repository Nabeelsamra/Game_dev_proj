using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Transform camera;

    private CharacterController charControl;
    private float originalOffset;

    // Start is called before the first frame update
    void Start()
    {
        charControl = GetComponent<CharacterController>();
        originalOffset = charControl.stepOffset;
    }

    // Update is called once per frame
    void Update()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horInput, 0, verInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);

        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            inputMagnitude /= 2;
        }

        float speed = inputMagnitude * moveSpeed;
        movementDirection.Normalize();

      
    }
}
