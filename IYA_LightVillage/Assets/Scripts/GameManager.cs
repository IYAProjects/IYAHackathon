using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TalkManager talkManager;
    publid QuestManager questManager;
    public GameObjects talkPanel;
    public Text talkText;
    public GameObjects scanObject;
    public bool isAction;
    public int talkIndex;
    
    public void Action(GameObject scanObj)
    {
        scanObject = scanObj;
        ObjData objData = scanObject.GetComponent<ObjData>();
        Talk(objData.id, objData.isNpc);

        talkPanel.SetActive(isAction);
    }

    void Talk()
    {   
        int GetQuestTalkIndex = QuestManager.GetQuestTalkIndex(id);
        string talkData = talkManager.GetTalk(id+ questTalkIndex, talkIndex);

        if(talkData == null) {
            isAction = false;
            talkIndex = 0;
            return;
        }

        if (isNpc) {
            talkText.text = talkData;
        }
        else {
            talkText.text = talkData;
        }

        isAction = true;
        talkIndex++;
    }
}
