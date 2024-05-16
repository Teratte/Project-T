using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rbody;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 화살표를 누르고 있는 경우
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 물체에 왼쪽 방향으로 물리적 힘을 가함. 왼쪽으로 이동
            rbody.AddForce(Vector2.left * moveSpeed, ForceMode2D.Impulse);

            // 일정 속도에 도달하면 더 이상 빨라지지 않음
            rbody.velocity = new Vector2(Mathf.Max(rbody.velocity.x, -maxSpeed), rbody.velocity.y);

            // scale 값을 이용해 캐릭터가 이동 방향을 바라보게 함
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽 화살표를 누르고 있는 경우
        {
            rbody.AddForce(Vector2.right * moveSpeed, ForceMode2D.Impulse);
            rbody.velocity = new Vector2(Mathf.Min(rbody.velocity.x, maxSpeed), rbody.velocity.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) // 이동 키를 뗀 경우
        {
            // x 속도를 줄여 이동 방향으로 조금만 이동 후 멈춤
            rbody.velocity = new Vector3(rbody.velocity.normalized.x, rbody.velocity.y);
        }
    }
}
