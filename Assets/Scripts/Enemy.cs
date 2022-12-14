using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Player _player;
    private float _speed;
    
    public float BaseSpeed;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _speed = BaseSpeed * (1 + Random.Range(-0.1f, 0.1f));
        _player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if(player != null)
        {
            transform.up = (_player.transform.position - transform.position).normalized;
            _rigidbody.velocity = (transform.up * _speed);
        }
        
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
