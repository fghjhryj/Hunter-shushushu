using UnityEngine;


/// <summary>
/// �ǲ��R�AAPI
/// �R�A static
/// </summary>

public class LeanAPIStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� static properties
        // 1. ���o get
        // ���o�R�A�ݩʻy�k
        // ���O�W�� . �R�A�ݩʦW��
        print("�H���� : " + Random.value);
        print("�ù��e�� : " + Screen.width);
        print("��P�v : " + Mathf.PI);

        // 2. �]�w set (Read Only ����]�w)
    }
}
