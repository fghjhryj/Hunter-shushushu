using UnityEngine;

namespace KID
{
    /// <summary>
    /// �����t�ΡG�����I���B���������m
    /// </summary>
    public class SystemCoin : MonoBehaviour
    {
        [SerializeField, Header("���𭸦�"), Range(0, 2)]
        private float delayFly = 1.5f;
        [SerializeField, Header("����t��"), Range(0, 10)]
        private float speed = 1.5f;

        /// <summary>
        /// �����n�e������m
        /// </summary>
        private Transform traCoinFlyTo;
        /// <summary>
        /// �}�l����
        /// </summary>
        private bool startFly;

        private ManagerCoin managerCoin;

        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);     // �����B�u�]�����I��
            Physics.IgnoreLayerCollision(6, 6);     // �����B���������I��
            Physics.IgnoreLayerCollision(6, 7);     // �����B�Ǫ������I��

            traCoinFlyTo = GameObject.Find("�����n�e������m").transform;
            managerCoin = GameObject.Find("�����޲z��").GetComponent<ManagerCoin>();

            Invoke("StartFly", delayFly);
        }

        private void Update()
        {
            Fly();
        }

        /// <summary>
        /// �}�l����
        /// </summary>
        private void StartFly()
        {
            startFly = true;
        }

        /// <summary>
        /// ����
        /// </summary>
        private void Fly()
        {
            if (!startFly) return;

            // ���ȡG�N A B ��Ӽƭȧ�X���������w��m
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, speed * Time.deltaTime);
            transform.position = traCoin;

            DestoryCoin();
        }

        /// <summary>
        /// �R������
        /// </summary>
        private void DestoryCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTo.position);

            if (dis < 2.5f)
            {
                managerCoin.AddCoinAndUpdateUI();
                Destroy(gameObject);
            }
        }
    }
}
