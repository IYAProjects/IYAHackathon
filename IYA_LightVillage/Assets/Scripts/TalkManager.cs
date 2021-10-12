using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typingfile2 : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenertateDate()
    {
        talkData.Add(id, new string[1]{"- 증상이 없어도 의심 된다면 코로나19 검사 받아주세요 -", "여기서 코로나 검사를 받는건가?"});
        talkData.Add(id, new string[2]{"전일빌딩 245?", "...", "전망이 좋을거같아"});
        talkData.Add(id, new string[3]{"강사님들이 그렇게 훌륭하시다던데", "두근거린다..!!!!!!!!"});
        talkData.Add(id, new string[4]{"- 위험하니 더 가까이 가실 수 없습니다. - ", "역시 광주에서 가장 큰 강 답군...!"});
    }


    public string GetTalk()
    {   
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[IDictionary][talkIndex];
    }
}
