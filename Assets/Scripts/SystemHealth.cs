using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace KID
{
    /// <summary>
    /// ��q�t�ΡG��s��q�B�����P���`�B�z
    /// </summary>
    public class SystemHealth : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("�e���ˮ`����")]
        private GameObject goDamage;
        [SerializeField, Header("�Ϥ���q")]
        private Image imgHp;
        [SerializeField, Header("��r��q")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("�Ǫ����")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("�ĤH�ʵe���")]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "Ĳ�o����";
        #endregion

        /// <summary>
        /// �I��|���˪�����W��
        /// </summary>
        [SerializeField, Header("�I��|���˪�����W��")]
        private string nameHurtObject;
        [Header("���a�����ˮ`�ϰ�")]
        [SerializeField] private Vector3 v3DamageSize;
        [SerializeField] private Vector3 v3DamagePosition;
        [SerializeField, Header("�����ˮ`���ϼh")]
        private LayerMask layerDamage;
        [SerializeField, Header("�O�_�����a")]
        private bool isPlayer;

        private SystemSpawn systemSpawn;
        private SystemFinal systemFinal;

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0.2f, 1, 0.2f, 0.5f);
            Gizmos.DrawCube(v3DamagePosition, v3DamageSize);
        }

        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
            systemFinal = FindObjectOfType<SystemFinal>();
        }

        private void Update()
        {
            CheckObjectInDamageArea();
        }

        // �I���ƥ�
        // 1. ��Ӫ��󥲶����@�ӱa�� Rigidbody
        // 2. ��Ӫ��󥲶����I���� Collider
        // 3. �O�_���Ŀ� Is Trigger
        // 3-1 ��̳��S���Ŀ� Is Trigger �ϥ� OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name.Contains(nameHurtObject))
                GetDamage(collision.gameObject.GetComponent<SystemAttack>().valueAttack);
        }

        /// <summary>
        /// �ˬd����O�_�i�J���˰ϰ�
        /// </summary>
        private void CheckObjectInDamageArea()
        {
            Collider[] hits = Physics.OverlapBox(
                v3DamagePosition, v3DamageSize / 2,
                Quaternion.identity, layerDamage);

            if (hits.Length > 0)
            {
                GetDamage(hits[0].GetComponent<SystemAttack>().valueAttack);
                Destroy(hits[0].gameObject);
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        private void GetDamage(float getDamage)
        {
            hp -= getDamage;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);
            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// ���`
        /// </summary>
        private void Dead()
        {
            if (isPlayer) systemFinal.ShowFinalAndUpdateSubTitle("�D�����d����...");
            else
            {
                Destroy(gameObject);
                systemSpawn.totalCountEnemyLive--;
                DropCoin();
            }
        }

        /// <summary>
        /// ��������
        /// </summary>
        private void DropCoin()
        {
            int range = Random.Range(dataEnemy.v2CoinRange.x, dataEnemy.v2CoinRange.y);

            for (int i = 0; i < range; i++)
            {
                float x = Random.Range(-1.5f, 1.5f);
                float z = Random.Range(-1.5f, 1.5f);
                float zAngle = Random.Range(0, 360);

                Instantiate(
                    dataEnemy.goCoin,
                    transform.position + new Vector3(x, 2.5f, z),
                    Quaternion.Euler(90, 180, zAngle));
            }
        }
    }
}
