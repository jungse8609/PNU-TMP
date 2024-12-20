using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private PlayerStatSO _playerStat = default;

    [Header("Gun Setting")]
    [SerializeField] private Transform _firePoint; // �߻� ��ġ
    
    [SerializeField] private int _maxBulletCount = 12;
    [SerializeField] private int _currentBulletCount = 0;

    public float MaxBulletCount { get { return _maxBulletCount; } }
    public float CurrentBulletCount { get { return _currentBulletCount; } }

    private BulletPoolManager _bulletPool = default;
    private bool isReloading = false;

    private void Awake()
    {
        _bulletPool = GetComponent<BulletPoolManager>();

        _currentBulletCount = 12;
    }

    public virtual void Fire()
    {
        if (isReloading) return;

        if (_currentBulletCount <= 0)
        {
            Reload();
            return;
        }

        // Create Bullet Prefab
        GameObject bullet = _bulletPool.GetBullet();
        bullet.transform.position = _firePoint.position;
        bullet.transform.rotation = _firePoint.rotation;

        TrailRenderer trail = bullet.GetComponent<TrailRenderer>();
        if (trail != null)
        {
            trail.Clear();
        }

        if (bullet.TryGetComponent<Bullet>(out Bullet bulletComponent))
        {
            bulletComponent.InitBullet(_bulletPool, _playerStat.BulletSpeed, _playerStat.BulletSpeed);
        }
        
        _currentBulletCount -= 1;

        if (_currentBulletCount <= 0)
        {
            Reload();
        }
    }

    public virtual void Reload()
    {
        if (isReloading == true)
            return;

        StartCoroutine(ReloadCoroutine());
    }

    private IEnumerator ReloadCoroutine()
    {
        isReloading = true;

        yield return new WaitForSeconds(_playerStat.ReloadCooltime);

        _currentBulletCount = _maxBulletCount;

        isReloading = false;
    }
}
