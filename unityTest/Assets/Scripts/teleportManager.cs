using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportManager : MonoBehaviour
{
    // canTeleport 변수를 static으로 선언
    public static bool canTeleport = true;

    public Vector3 playerStartPosition = new Vector3(0, 0, 0); // 플레이어의 원점 위치

    public GameObject spaces;
    private List<GameObject> spaceList;

    private void Start()
    {
        spaceList = new List<GameObject>();

        // spaces 오브젝트의 자식들을 spaceList에 추가
        foreach (Transform child in spaces.transform)
        {
            spaceList.Add(child.gameObject);
        }
    }

    public void EnterPortals(GameObject scene)
    {
        if (canTeleport)
        {
            // 플레이어의 위치를 포탈의 위치로 이동
            // 플레이어 태그로 찾기
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = playerStartPosition;
            Debug.Log(player.transform.position)
;
            // scene을 제외하고 spaceList의 다른 GameObject들을 비활성화
            foreach (GameObject space in spaceList)
            {
                if (space != scene)
                {
                    space.SetActive(false);
                }
                else
                {
                    Debug.Log(space.name);
                }
            }
        }
        else
        {
            Debug.Log("포탈 이동 불가능");
        }
    }
}
