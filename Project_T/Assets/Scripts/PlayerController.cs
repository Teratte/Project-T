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
        // ���� ȭ��ǥ�� ������ �ִ� ���
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ��ü�� ���� �������� ������ ���� ����. �������� �̵�
            rbody.AddForce(Vector2.left * moveSpeed, ForceMode2D.Impulse);

            // ���� �ӵ��� �����ϸ� �� �̻� �������� ����
            rbody.velocity = new Vector2(Mathf.Max(rbody.velocity.x, -maxSpeed), rbody.velocity.y);

            // scale ���� �̿��� ĳ���Ͱ� �̵� ������ �ٶ󺸰� ��
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) // ������ ȭ��ǥ�� ������ �ִ� ���
        {
            rbody.AddForce(Vector2.right * moveSpeed, ForceMode2D.Impulse);
            rbody.velocity = new Vector2(Mathf.Min(rbody.velocity.x, maxSpeed), rbody.velocity.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) // �̵� Ű�� �� ���
        {
            // x �ӵ��� �ٿ� �̵� �������� ���ݸ� �̵� �� ����
            rbody.velocity = new Vector3(rbody.velocity.normalized.x, rbody.velocity.y);
        }
    }
}
