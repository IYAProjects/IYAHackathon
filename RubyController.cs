using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;   // Position�̶�� ���� ����, ����� ���� ��ġ ����
        position.x = position.x + 0.1f;          // x ��ǥ�� ���������� 0.1 ���� �̵��� ��
        transform.position = position;
    }
}
