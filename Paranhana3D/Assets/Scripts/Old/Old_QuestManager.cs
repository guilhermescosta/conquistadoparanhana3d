using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Quest quest = new Quest();
    public GameObject questPrintBox;
    public GameObject buttonPrefab;

    public GameObject A;
    public GameObject B;
    public GameObject C;


    private void Start()
    {
        /*
        QuestEvent a = quest.AddQuestEvent("test1", "description1");
        QuestEvent b = quest.AddQuestEvent("test2", "description2");
        QuestEvent c = quest.AddQuestEvent("test3", "description3");
        QuestEvent d = quest.AddQuestEvent("test4", "description4");
        QuestEvent e = quest.AddQuestEvent("test5", "description5");

        quest.AddPath(a.GetId(), b.GetId());
        quest.AddPath(b.GetId(), c.GetId());
        quest.AddPath(b.GetId(), d.GetId());
        quest.AddPath(c.GetId(), e.GetId());
        quest.AddPath(d.GetId(), e.GetId());

        quest.BFS(a.GetId());

        QuestButton button = CreateButton(a).GetComponent<QuestButton>();
        A.GetComponent<QuestLocation>().Setup(this, a, button);
        button = CreateButton(b).GetComponent<QuestButton>();
        B.GetComponent<QuestLocation>().Setup(this, b, button);
        button = CreateButton(c).GetComponent<QuestButton>();

        quest.PrintPath();
        */
    }

    GameObject CreateButton(QuestEvent e)
    {
        GameObject b = Instantiate(buttonPrefab);
        b.GetComponent<QuestButton>().Setup(e, questPrintBox);
        if (e.order == 1)
        {
            b.GetComponent<QuestButton>().UpdateButton(QuestEvent.EventStatus.CURRENT);
            e.status = QuestEvent.EventStatus.CURRENT;
        }
        return b;
    }

    public void UpdateQuestsOnCompletion(QuestEvent e)
    {
        /*
        foreach (QuestEvent n in quest.questEvents)
        {
            if (n.order == (e.order + 1))
            {
                n.UpdateQuestEvent(QuestEvent.EventStatus.CURRENT);
            }
        }
        */
    }

}
