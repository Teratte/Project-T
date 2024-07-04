using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;
    public Vector2 inputVec;

    [SerializeField]
    public float speed;
 
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rbody.MovePosition(rbody.position + nextVec);

    }
}
