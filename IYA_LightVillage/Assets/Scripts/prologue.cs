using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prologue : MonoBehaviour
{   
    public Text tx;
    private string m_text = "여기가 바로.. 빛고을, Light Village? \n도착했다 나의 꿈을 펼칠 수 있는 도시에!!";

    void Start()
    {
        StartCoroutine(_typing());
    }

IEnumerator _typing()
    {
        yield return new WaitForSeconds(0f);
        for (int i =0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0,i);

            yield return new WaitForSeconds(0.05f);
        }
    }
}
