using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    //player_Setting
    public float Speed;
    [SerializeField] KeyCode MoveLeft = KeyCode.LeftArrow;
    [SerializeField] KeyCode MoveRight = KeyCode.RightArrow;
    [SerializeField] KeyCode MoveFront = KeyCode.UpArrow;
    [SerializeField] KeyCode MoveBack = KeyCode.DownArrow;
    private Rigidbody Rb;


    //CollectCoin
    public static int Coins;

    void Start()
    {
        Rb = this.GetComponent<Rigidbody>();
        Coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    public void Movement()
    {
        if (Input.GetKey(MoveLeft))
        {
            Rb.AddForce(new Vector3(-1 * Speed, 0, 0), ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveRight))
        {
            Rb.AddForce(new Vector3( Speed, 0, 0), ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveFront))
        {
            Rb.AddForce(new Vector3(0, 0,  Speed), ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(MoveBack))
        {
            Rb.AddForce(new Vector3(0, 0, -1 * Speed), ForceMode.VelocityChange);
        }
        else
        {
            Rb.velocity = Vector3.zero;
        }
    }
    public void Movement_Translate()
    {
        if (Input.GetKey(MoveLeft))
        {
            transform.Translate(new Vector3(-1 * Speed, 0, 0));
        }
        if (Input.GetKey(MoveRight))
        {
            transform.Translate(new Vector3(Speed, 0, 0));
        }
        
        if (Input.GetKey(MoveFront))
        {
            transform.Translate(new Vector3(0, 0, Speed));
        }
       
        if (Input.GetKey(MoveBack))
        {
            transform.Translate(new Vector3(0, 0, -1 * Speed));
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Coins++;
            Debug.Log(Coins);
        }
    }
}
