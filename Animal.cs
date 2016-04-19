class Animal {
    private string _name = "";
    public int _legs = 0;
    public double _speed = 0.0;
    public bool _isMoving = false;
    public double speed{
        get{return _speed;}
        set{_speed=value;}
    }
    public string genus {get;set;}
    public void walk() {
        _isMoving = true;
        _speed = _speed + (0.1 *_legs);
    }
}