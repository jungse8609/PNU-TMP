using UnityEngine;

public class Droppable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("������ ȹ���ε� �̰� �椷�� ���� ������ ���� ������ ü�����̳� ������");
            gameObject.SetActive(false);
        }
    }
}
