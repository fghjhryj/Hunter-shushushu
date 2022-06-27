using UnityEngine;


/// <summary>
/// �ǲ߹B��l
/// 1. �ƾǹB��l
/// 2. ����B��l
/// 3. �޿�B��l
/// </summary>



public class LeanOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private int c = 99;
    private int d = 1;

    private int diamond = 1;
    private int hp = 100;



    private void Start()
    {
        #region �ƾǹB��l
        // �[ +
        // �� -
        // �� *
        // �� /
        // �l %
        print("�[�k : " + (a + b));     // 13
        print("��k : " + (a - b));     // 7
        print("���k : " + (a * b));     // 30
        print("���k : " + (a / b));     // 3.3333
        print("�l�k : " + (a % b));     // 1
        #endregion

        #region ����B��l
        // �j�� >
        // �p�� <
        // �j�󵥩� >=
        // �p�󵥩� <=
        // ������ !=
        // ����  ==
        

        // ����B��l�����G�����L�� : ture�Bfalse
        print("�j�� : " + (c > d));     // true
        print("�p�� : " + (c < b));     // false
        print("�j�󵥩� : " + (c >= d));     // ture
        print("�p�󵥩� : " + (c <= d));     // false
        print("������ : " + (c != d));     // ture
        print("���� : " + (c == d));     // false
        #endregion


        // �޿�B��l�A�w�塞�L��
        // �åB && : ��ӥ��L�Ȧ��@�� false ���G�N�O false
        print("true && true : " + (true && true));       // true
        print("true && false : " + (true && false));     // false
        print("false && true : " + (false && true));     // false
        print("false && false : " + (false && false));   // false

        // �Ϊ� || : ��ӥ��L�Ȧ��@�� ture ���G�N�O ture
        print("true || true : " + (true || true));       // true
        print("true || false : " + (true || false));     // true
        print("false || true : " + (false || true));     // true
        print("false || false : " + (false || false));   // false

        // �C���d�� :
        // �ӧQ���� : �_�� >= 3 �� �åB ��q�j�� 0 �~��L��
        print("�O�_�L�� :" + (diamond >= 3 && hp > 0));

        // �A�˹B��l  !
        // �@�� : �N���L���ܬۤ�
        print("!true" + (!true));       // false
        print("!false" + (!false));       // true
    }
}
