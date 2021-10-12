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
        Vector2 position = transform.position;   // Position이라는 변수 선언, 루비의 현재 위치 저장
        position.x = position.x + 0.1f;          // x 좌표는 오른쪽으로 0.1 유닛 이동한 값
        transform.position = position;
    }
}
