using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using UnityEngine;

/// <summary>
/// �ǲ߰j��  ��P�{��  Coroutine : ����
/// while�Bfor �о�
/// while do�Bforeach
/// </summary>

public class LeanLoop : MonoBehaviour
{
    private void Start()
    {
        // �j�� : ���ư���

        // while �j��y�k :
        // if (���L��) { �{�� } ����@��
        // while (���L��) { �{�� } ���ư���쥬�L�Ȭ� false


        int count = 0;

        while (count < 5)
        {
            print("while �j�� ! " + count);
            count++;
        }

        // for(��l�� ; ���� ; �j������B�z)  { �{�� }
        for (int i = 0; i < 5; i++)

            // ��P�{��
            // 1. �ޥΩR�W�Ŷ� System.Collections
            // 2. �w�׶Ǧ^������ IEnumerator ����k
            // 3. yield return ����
            // 4. Start Coroutine �Ұ�
            StartCoroutine(Test());

    }

    private IEnumerator Test()
    {

        print("<color=yellow>�Ĥ@��</color>");
        yield return new WaitForSeconds(1);
        print("<color=yellow>�ĤG��</color>");
    }


}
