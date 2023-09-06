
namespace Kmart.Core.Interface
{
    public interface ILongestIncreasingSubsequenceService
    {
        public IEnumerable<int> CovertStringToList(string stringInput);

        public string FindLongestIncreasingSubsequence(IList<int> list);
    }
}