namespace ArrayCalcAPI.Interfaces
{
    public interface IArrayManipulationService
    {
        int[] ReverseArray(string[] array);
        int[] DeleteArrayElement(string[] array, string position);
    }
}
