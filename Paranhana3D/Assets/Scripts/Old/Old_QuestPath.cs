using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPath
{
    public QuestEvent questStart;
    public QuestEvent questEnd;

    public QuestPath(QuestEvent from, QuestEvent to)
    {
        questStart = from;
        questEnd = to;

    }
}
