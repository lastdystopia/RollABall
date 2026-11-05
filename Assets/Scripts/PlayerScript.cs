using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    public TextMeshProUGUI countText;
    private float movementX;
    private float movementY;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }
    void OnMove(InputValue movementValue){
Vector2 movementVector = movementValue.Get<Vector2>(); 
    movementX = movementVector.x;
    movementY = movementVector.y;
    }
    void SetCountText()
    {
        countText.text = "Count: "+ count.ToString();
    }
    void FixedUpdate(){
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
        // other: addresses other object being collided with
        // gameObject: the game object (from other)
        // SetActive(false): deactivates that other game object
        other.gameObject.SetActive(false);
        count++;
        SetCountText();
        }
    }
}
