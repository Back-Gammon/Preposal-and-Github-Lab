using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    private bool turnLeft, turnRight, jumpInput;
    public float speed = 7.0f;
    private float ySpeed;
    private CharacterController myCharacterController;
  

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
    }
    private void FixedUpdate()
    {
        if (!alive) return;    
    }

    // Update is called once per frame
    void Update()
    {
        turnLeft = Input.GetKeyDown(KeyCode.A);
        turnRight = Input.GetKeyDown(KeyCode.D);
        jumpInput = Input.GetKeyDown(KeyCode.W);

        if (turnLeft)
        transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
        transform.Rotate(new Vector3(0f, 90f, 0f));
        else if (jumpInput){
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f);
        }

      //  ySpeed += Physics.gravity.y * TIme.deltaTime;

       //  jump =  (Input.GetKeyDown(KeyCode.Space))
       

       

        if (transform.position.y < 40)
        {
            Die();
        }

        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);

    }




    public void Die()
    {
        alive = false;
        //restart the game
        Invoke ("Restart", 1);
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
