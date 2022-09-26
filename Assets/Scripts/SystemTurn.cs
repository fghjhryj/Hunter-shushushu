using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace KID
{
    /// <summary>
    /// �^�X�t�ΡG���a�μĤH�^�X�޲z
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        #region ���
        /// <summary>
        /// �ĤH�^�X
        /// </summary>
        public UnityEvent onTurnEnemy;

        [SerializeField, Header("�S�����ʪ���åB����ͦ����ɶ�"), Range(0, 3)]
        private float noMoveObjectAndDelaySpawn = 1;
        [SerializeField, Header("��e�h�Ƴ̤j��"), Range(1, 100)]
        private int countFloorMax = 50;

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// �u�]�`��
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// �Ǫ��P�i�H�Y���u�]�s���`��
        /// </summary>
        private int totalCountEnemyLive;
        /// <summary>
        /// �^���u�]�ƶq
        /// </summary>
        private int totalRecycleMarble;
        private bool canSpawn = true;
        private int countMarbleEat;
        /// <summary>
        /// �h�ƼƦr
        /// </summary>
        private TextMeshProUGUI textFloorCount;
        private int countFloor = 1;
        private bool isFloorCountMax;
        #endregion

        private SystemFinal systemFinal;

        private void Awake()
        {
            systemControl = GameObject.Find("�����L").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("�^���ϰ�").GetComponent<RecycleArea>();
            textFloorCount = GameObject.Find("�h�ƼƦr").GetComponent<TextMeshProUGUI>();

            recycleArea.onRecycle.AddListener(RecycleMarble);

            systemFinal = FindObjectOfType<SystemFinal>();
        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            // print("<color=yellow>�u�]�^���ƶq�G" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                // print("�^�������A���ĤH�^�X");
                onTurnEnemy.Invoke();

                // �p�G�S���ĤH�N���ʵ����åͦ��ĤH�P�u�]
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    Invoke("MoveEndSpawnEnemy", noMoveObjectAndDelaySpawn);
                }
            }
        }

        /// <summary>
        /// ���ʵ�����ͦ��ĤH�P�u�]
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;
            if (!isFloorCountMax)
            {
                canSpawn = false;
                systemSpawn.SpawnRandomEnemy();
            }

            Invoke("PlayerTurn", 1);
        }

        /// <summary>
        /// ���a�^�X
        /// </summary>
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;

            #region �u�]�ƶq�B�z
            systemControl.canShootMarbleTotal += countMarbleEat;
            countMarbleEat = 0;
            #endregion

            if (countFloor < countFloorMax)
            {
                countFloor++;
                textFloorCount.text = countFloor.ToString();
            }
            if (countFloor == countFloorMax) isFloorCountMax = true;

            if (isFloorCountMax)
            {
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    systemFinal.ShowFinalAndUpdateSubTitle("���߬D�����d���\�I");
                }
            }
        }

        /// <summary>
        /// �Y��u�]�ƶq���W
        /// </summary>
        public void MarbleEat()
        {
            countMarbleEat++;
        }
    }
}