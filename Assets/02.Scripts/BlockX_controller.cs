using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockX_controller : MonoBehaviour
{

    private Vector2 mousePosition; //���콺 ��ġ
    private float deltaX, distance; //���� x��ǥ, �Ÿ�
    public float speed; //�� �̵��ӵ�
    public Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag() //���콺�� �巡�����϶� �۵��ϴ� �Լ�
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //���� ���콺�� ��ġ
        deltaX = transform.position.x; //���� x��ǥ
        distance = Mathf.Abs(mousePosition.x - deltaX); //�Ÿ� = (���콺�� x��ǥ - ���� x��ǥ)�� ����

        if (distance < 0.05) //�Ÿ��� ������ �̵����� �ʵ��� �ӵ��� 0���� ����
        {
            speed = 0;
        }
        else
        {
            speed = distance * 1.5f; //�Ÿ� * 1.5�� �ӵ��� ����
        }

        if (mousePosition.x > deltaX) //���콺�� ���� ��ġ�� ���� �� �̵� ���� ����
        {
            body.velocity = Vector3.right * speed; //���� �ӵ��� �����Ͽ� �̵���Ų��.
        }
        else if (mousePosition.x < deltaX)
        {
            body.velocity = Vector3.left * speed;
        }
        //this.transform.position = new Vector2(mousePosition.x - deltaX, deltaY);
    }

    private void OnMouseUp()
    {
        body.velocity = new Vector3(0, 0, 0); //���콺���� ���� ���� ���� �ӵ� 0���� ����(���Ŀ� ����ĭ�� ���� �̵��ϵ��� �缳��)
    }

}