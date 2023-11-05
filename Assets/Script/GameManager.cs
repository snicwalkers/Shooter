using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float attackSpeedMultiplier = 1f;
    public static void increasedMultiplier(float amount)
    {
        attackSpeedMultiplier *= amount;
    }
}
