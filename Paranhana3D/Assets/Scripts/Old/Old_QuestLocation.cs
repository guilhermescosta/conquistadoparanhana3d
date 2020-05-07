using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLocation : MonoBehaviour
{
    public QuestManager _questManager;
    public QuestEvent _questEvent;
    public QuestButton _questButton;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player") return;

        if (_questEvent.status != QuestEvent.EventStatus.CURRENT) return;

        _questEvent.UpdateQuestEvent(QuestEvent.EventStatus.DONE);
        _questButton.UpdateButton(QuestEvent.EventStatus.DONE);
        _questManager.UpdateQuestsOnCompletion(_questEvent);

    }

    public void Setup(QuestManager qm, QuestEvent qe, QuestButton qb)
    {
        _questManager = qm;
        _questEvent = qe;
        _questButton = qb;

        qe.button = _questButton;
    }
}
