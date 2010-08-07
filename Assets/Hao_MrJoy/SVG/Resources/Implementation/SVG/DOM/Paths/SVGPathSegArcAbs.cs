public class SVGPathSegArcAbs : SVGPathSeg, ISVGDrawableSeg  {
  private float _x      = 0f;
  private float _y      = 0f;
  private float _r1      = 0f;
  private float _r2      = 0f;
  private float _angle    = 0f;
  private bool _largeArcFlag  = false;
  private bool _sweepFlag  = false;
  //================================================================================
  public float x {
    get{ return this._x;}
  }
  //-----
  public float y {
    get{ return this._y;}
  }
  //================================================================================
  public SVGPathSegArcAbs(float r1, float r2, float angle,
              bool largeArcFlag, bool sweepFlag,
              float x, float y) : base() {
    this._r1 = r1;
    this._r2 = r2;
    this._angle = angle;
    this._largeArcFlag = largeArcFlag;
    this._sweepFlag = sweepFlag;
    this._x = x;
    this._y = y;
  }
  //================================================================================
  public override SVGPoint currentPoint{
    get{
      return new SVGPoint(this._x, this._y);
    }
  }
  //--------------------------------------------------------------------------------
  //Method: Render
  //--------------------------------------------------------------------------------
  public void Render(SVGGraphicsPath _graphicsPath) {
    SVGPoint p;
    p = currentPoint;
    _graphicsPath.AddArcTo(this._r1, this._r2, this._angle,
            this._largeArcFlag, this._sweepFlag, p);
  }
}