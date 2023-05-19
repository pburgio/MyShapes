namespace MyShapes
{
    /// <summary>
    /// Interface of a generic shape. As use-case, we must be able to compute its area
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Compute the area of the shape
        /// </summary>
        /// <returns></returns>
        int CalcArea();
    }
}
