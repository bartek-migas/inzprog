public static (double? x1, double? x2) RozwiazRownanieKwadratowe(double a, double b, double c)
{
    double delta = b * b - 4 * a * c;
    if (delta < 0) return (null, null);
    if (delta == 0) return (-b / (2 * a), null);
    double sqrtDelta = Math.Sqrt(delta);
    return ((-b - sqrtDelta) / (2 * a), (-b + sqrtDelta) / (2 * a));
}
