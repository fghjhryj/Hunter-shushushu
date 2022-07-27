using UnityEngine;
using System.Collections;

// �R�W�Ŷ� namespace �Ŷ��W�� { �ӪŶ������e }
namespace KID
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region ���
        // GameObject �C������
        // �s�񶥼h���O���Ϊ̱M�פ�������
        [Header("�b�Y")]
        public GameObject arrow;
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        [Header("�u�]�w�s��")]
        public GameObject marble;
        [Header("�u�]�i�H�o�g���`��"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        [Header("�u�]�ͦ��I")]
        public Transform traSpawnPoint;
        [Header("�����ѼƦW��")]
        public string parAttack = "Ĳ�o����";
        [Header("�u�]�o�g�t��"), Range(0, 5000)]
        public float speedMarble = 1000;
        [Header("�u�]�o�g���j"), Range(0, 2)]
        public float intervalMarble = 0.5f;
        [Header("�u�]�ƶq")]
        public TextMeshProUGUI textMarbleCount;

        public Animator ani;
        /// <summary>
        /// ��_�o�g�u�]
        /// </summary>
        private bool canShootMarble = true;
        /// <summary>
        /// �ഫ�ƹ�����v��
        /// </summary>
        private Camera cameraMouse;
        /// <summary>
        /// �y���ഫ����骫��
        /// </summary>
        private Transform traMouse;
        #endregion

        #region �ƥ�
        // Awake �b Start ���e����@��
        private void Awake()
        {
            ani = GetComponent<Animator>();

            textMarbleCount.text = "x" + canShootMarbleTotal;

            cameraMouse = GameObject.Find("�ഫ�ƹ�����v��").GetComponent<Camera>();

            // traMous = GameObject.Find("�y���ഫ����骫��").GetComponent<Transform>();
            traMouse = GameObject.Find("�y���ഫ����骫��").transform;

            // ���z �����ϼh(�ϼh1 �A �ϼh2)
            Physics.IgnoreCollision(3, 3);
        }

        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��A�����⭱�V�ƹ�����m
        /// </summary>
        private void TurnCharacter()
        {
            // �p�G ����o�g �N���X
            if (!cameraMouse) return;
            
            // 1. �ƹ��y��
            Vector3 posMouse = Input.mousePosition;

            // print("<color=yellow>�ƹ��y�� : " + posMouse + "</color>");
            // ����v���� Y �b�@��
            posMouse.z = 25;

            // 2. �ƹ��y���ର�@�ɮy��
            Vector3 pos = cameraMouse.ScreenToWorldPoint(posMouse);
            // �N�ഫ�����@�ɮy�а��׳]�����⪺����
            pos.y = 0.5f;
            // 3. �@�ɮy�е����骫��
            traMouse.position = pos;

            // �������ܧ�.���V(�y���ഫ����骫��)
            transform.LookAt(traMouse);
        }

        /// <summary>
        /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {
            // �p�G ����o�g�u�] �N���X
            if (!canShootMarble) return;

            // ���U �ƹ����� ��� �b�Y
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            // ��} �ƹ����� ���ýb�Y �ͦ��õo�g�u�]
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // ����o�g�u�]
                canShootMarble = false;
                
                // print("��}����I");
                arrow.SetActive(false);
                StartCoroutine(SpawnMarble());
            }
        }

        /// <summary>
        /// �ͦ��u�]���a���j�ɶ�
        /// </summary>
        private IEnumerator SpawnMarble()
        {
            int total = canShootMarbleTotal;
            
            for (int i = 0; i < canShootMarbleTotal; i++)
            {
                ani.SetTrigger(parAttack);

                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�])�F
                // Quaternion.identity �s�ר�
                GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
                // �Ȧs�u�] ���o���餸�� �K�[���O (����.�e�� * �t��)
                // transform.forward ���⪺�e��
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                total--;

                if (total > 0) textMarbleCount.text = "x" + total;
                else if (total == 0) textMarbleCount.text = "";

                yield return new WaitForSeconds(intervalMarble);
            }
        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }
        #endregion
    }
}

