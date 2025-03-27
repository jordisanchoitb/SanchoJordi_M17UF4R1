using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DieState", menuName = "StatesSO/Die")]
public class DieState : StateSO
{
    public override void OnStateEnter(Enemy enemy)
    {
        Debug.Log("Abandon� este mundo de miseria y desesperaci�n");
    }

    public override void OnStateExit(Enemy enemy)
    {
    }

    public override void OnStateUpdate(Enemy enemy)
    {
    }
}
