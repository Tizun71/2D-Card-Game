using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject[] enemiesPrefab;

    public Transform playerBattleStation;
    public Transform[] enemiesBattleStation;

    private Unit playerUnit;
    private Unit[] enemiesUnit;

    GameObject[] enemiesGO;
    public void SetUpBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        
        for (int i = 0; i < enemiesBattleStation.Length; i++)
        {
            if (i <= enemiesPrefab.Length)
            {
                enemiesGO[i] = Instantiate(enemiesPrefab[i], enemiesBattleStation[i]);
                enemiesUnit[i] = enemiesGO[i].GetComponent<Unit>();
            }
        }
    }
}
