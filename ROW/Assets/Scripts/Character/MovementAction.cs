using UnityEngine;
using UnityEngine.UIElements;

public class MovementAction : MonoBehaviour
{
    [SerializeField] private float verticalPull = -5f;
    [SerializeField] private float moveSpeed = 6.0f;

    private Player _player;
    private CharacterController _characterController;

    private void Awake()
    {
        _player = GetComponent<Player>();
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        OnUpdate();
        Move();
        GroundGravity();
    }

    private void OnUpdate()
    {
        Move();
        GroundGravity();
        Rotate();
    }

    private void Move()
    {
        _player.movementVector.x = _player.movementInput.x * moveSpeed;
        _player.movementVector.z = _player.movementInput.z * moveSpeed;

        _characterController.Move(_player.movementVector * Time.deltaTime);
        _player.movementVector = _characterController.velocity;
    }

    private void GroundGravity()
    {
        _player.movementVector.y = verticalPull;
    }

    private void Rotate()
    {
        // �÷��̾� ���̿� ������ y ��ġ�� ��� ����
        Plane plane = new Plane(Vector3.up, _player.transform.position);

        // ī�޶󿡼� ���콺 ��ġ���� Ray ����
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Ray�� ���� �����ϴ� ���� ���
        if (plane.Raycast(ray, out float distance))
        {
            Vector3 mouseWorldPosition = ray.GetPoint(distance);

            // ������Ʈ ��ġ �� ���� ����
            Vector3 direction = (mouseWorldPosition - _player.transform.position).normalized;
            transform.LookAt(mouseWorldPosition);
        }
    }
}
