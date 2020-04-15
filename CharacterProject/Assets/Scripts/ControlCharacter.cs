using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ControlCharacter : MonoBehaviour
{

    public CharacterController controller;

    public Vector3 Location, Orientation;

    public float speed = 12f, orientSpeed = 4f, gravity = -9.81f, jumpSpeed = 40f;

    public FloatData health;

    public GameObject endGameCanvas;

    public int jumpCount = 2;
    
   
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            Location.x = (Input.GetAxis("Vertical")*speed);
            Location.z = 0;
            Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
            controller.transform.Rotate(Orientation);
            Location = controller.transform.TransformDirection(Location);
            jumpCount = 2;
        }
        
        
        if (Location.x != 0)
        {
            if (Location.z != 0)
            {
                Location.x = (Input.GetAxis("Vertical")*speed);
                Location.z = 0;
                Orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
            }
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount <= 0)
            {
                return;
            }
            else
            {
                Location.y = jumpSpeed;
                jumpCount--;
            }
            
            
        }
        
        
        Location.y += gravity;
        
        controller.Move(Location * Time.deltaTime);

        if (health.value <= 0)
        {
            TurnOnAndOff(endGameCanvas);
        }
        else
        {
            return;
        }

        void TurnOnAndOff(GameObject obj)
        {
            obj.SetActive(true);
        }

       
    }
    
    

}
