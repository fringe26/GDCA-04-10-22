public class Bullet20 : Bullet_base
{
    private new int _damage;

    public int Damage => _damage;
    public override void Initialize()
    {
        _damage = 20;
    }
}