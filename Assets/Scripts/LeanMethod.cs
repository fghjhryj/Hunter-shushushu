using UnityEngine;

public class LeanMethod : MonoBehaviour
{
    // ��k�y�k
    // �Ǧ^���� ��k�ۭq�W�� () { ��k���e }
    // �L�Ǧ^ void
    // ��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Test()
    {
        // ��X(��X�T��);
        print("���o �U�w :D");
    }

    // �ۭq��k
    // �ݭn�I�s�~�|����

    // Unity ���J�f
    // �}�l�ƥ� (�Ŧ�W��)
    // ����C����|����@��
    // ��l�Ƴ]�w : ��l���B�B�T���R����
    private void Start()
    {
        // �I�s��k
        // ��k�W��()�F
        Test();
        PrintColorText();
     }
    private void PrintColorText()
    {
        // Rich Text
        print("<color=yellow>����T��</color>");
        print("<color=red>����T��</color>");
        print("<size=10><color=#003399>�Ŧ�T��</color></size>");
    }
}
