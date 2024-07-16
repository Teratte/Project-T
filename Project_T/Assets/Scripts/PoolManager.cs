using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // �����յ��� ������ ����
    public GameObject[] prefabs;

    // Ǯ ����� �ϴ� ����Ʈ�� �ʿ� (1 �� 1 �����̱� ������ ������ 2���� ����Ʈ�� 2������ ��)
    List<GameObject>[] pools;

    void Awake()
    {
        pools = new List<GameObject>[prefabs.Length]; // ���� 2

        for (int i = 0; i < pools.Length; i++)
        {
            pools[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;

        // ������ Ǯ�� ��Ȱ��ȭ �� ���ӿ�����Ʈ ����         
        foreach (GameObject item in pools[index])
        {
            if(!item.activeSelf)
            {
                // �߰��ϸ� select ������ �Ҵ�
                select = item;
                select.SetActive(true);
                break;
            }
        }

        // �� ã������ ?
        if(select == null)
        {
            // ���Ӱ� �����ϰ� select ������ �Ҵ�
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }

        return select;
    }
}