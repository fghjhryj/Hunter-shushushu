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

        print("�Ǧ^ 10 ��k���G : " + ReturnTen());
        print("�ӫ~�`�� : " + CalculatePrice());


        Shoot("���y");                // �S����ѼƷ|�H�w�]�Ȱ���
        Shoot("�q�y");
        Shoot("�B�y", "������");      // �л\�Ѽ�
        Shoot("���y", "�զ⳷��");      // �����w���浲�G���~
        Shoot("���y", effect: "������");   // ���y�A�������A���w �ѼƦW��: �զ⳷��
    }

    // ��k�y�k
    // �׹��� �Ǧ^���� ��k�ۭq�W�� () { ��k���e }
    // �L�Ǧ^ void
    // ��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Text()
    {

    }

    #region ��k�m��
    private void PrintColorText()
    {
        // Rich Text
        print("<color=yellow>����T��</color>");
        print("<color=red>����T��</color>");
        print("<size=10><color=#003399>�Ŧ�T��</color></size>");
    }

    // �Ǧ^��k
    // �����f�t return
    private int ReturnTen()
    {
        // �Ǧ^ ��� (����ƥ����P�Ǧ^�����ۦP)
        return 10;
    }

    // �ө��t�� : 99 ���A�p������ӫ~����
    private int countProduct = 10;
    private int countPrice = 99;


    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion

    // �o�g���y�B�o�g�q�y
    // ���񭵮�
    private void Fire()
    {
        print("�o�g���y");
        print("�o�g����");
    }

    private void ShootLoghting()
    {
        print("�o�g�q�y");
        print("�o�g���y");
    }

    // �Ѽƻy�k : �Ѽ����� �ѼƦW�� ���w �w�]��
    // ���w�]�Ȫ��Ѽƥ�����b�̥k��
    private void Shoot(string type, string sound = "������", string effect = "����")
    {
        print("�o�g : " + type);
        print("���� : " + sound);
        print("�S�� : " + effect);
    }

    // ��k���h�� overload
    // �w�q :
    // 1. �ۦP�W�٪���k
    // 2. �����P�ƶq���ѼƩΪ̤��P�������Ѽ�
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("��Z�������A�����O :" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("���Z�������A�����O :" + atk);
        print("�o�g���� :" + ball);
    }

}
