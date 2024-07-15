using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;
    public Vector2 inputVec;
    private int currentHP = 0;

    [SerializeField]
    public float speed;         // 플레이어 이동속도
    [SerializeField]
    public int maxHP;           // 플레이어의 최대 체력
 
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        Debug.Log(currentHP);
    }
    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rbody.MovePosition(rbody.position + nextVec);
    }
}
