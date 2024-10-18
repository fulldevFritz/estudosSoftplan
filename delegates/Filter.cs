public class Filter
{
    public List<int> FilterNumbers(List<int> numbers, FilterDelegate filter)
    {
        return numbers.Where(n => filter(n)).ToList();
    }
}