using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEditorInternal;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    private int count;

    
    private Rigidbody rb;

    private float movementX;
    private float movementY;

    public float speed = 0;

    public GameObject winTextObject;

    public GameObject OuchTextObject;


    public TextMeshProUGUI countText;

    
    void Start()
    {
        winTextObject.SetActive(false);
        

        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        OuchTextObject.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();

        if (count >= 19)
        {
            winTextObject.SetActive(true);
        }

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ouch"))
        {
            OuchTextObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        
    }
    


}
